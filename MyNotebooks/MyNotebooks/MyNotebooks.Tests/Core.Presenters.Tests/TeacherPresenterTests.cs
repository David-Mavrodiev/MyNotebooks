using Moq;
using MyNotebooks.Core.Presenters;
using MyNotebooks.Core.Views;
using MyNotebooks.DataModels.Models;
using MyNotebooks.Services.Contracts;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.Core.Presenters.Tests
{
    [TestFixture]
    public class TeacherPresenterTests
    {
        [Test]
        public void TeacherPresenter_Should_Initialize_A_Object()
        {
            var mockedView = new Mock<ITeacherView>();
            var mockedService = new Mock<IRelationshipService>();

            var presenter = new TeacherPresenter(mockedView.Object, mockedService.Object);

            Assert.IsInstanceOf<TeacherPresenter>(presenter);
        }

        [Test]
        public void TeacherPresenter_Should_SetTitles_When_Raise_Load()
        {
            var mockedView = new Mock<ITeacherView>();
            mockedView.SetupAllProperties();
            mockedView.Setup(v => v.SetDropdown());
            mockedView.SetupGet(v => v.Username).Returns("test");

            var mockedService = new Mock<IRelationshipService>();
            mockedService.SetupAllProperties();
            mockedService.Setup(s => s.Find(It.IsAny<string>())).Returns(new List<Relationship>());

            var presenter = new TeacherPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());

            Assert.IsTrue(mockedView.Object.Titles != null && mockedView.Object.Titles.Count > 0);
        }

        [Test]
        public void TeacherPresenter_Should_SetGetRelationships_When_Raise_Load()
        {
            var list = new List<Relationship>();

            var mockedView = new Mock<ITeacherView>();
            mockedView.SetupAllProperties();
            mockedView.Setup(v => v.SetDropdown());
            mockedView.SetupGet(v => v.Username).Returns("test");

            var mockedService = new Mock<IRelationshipService>();
            mockedService.SetupAllProperties();
            mockedService.Setup(s => s.Find(It.IsAny<string>())).Returns(list);

            var presenter = new TeacherPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());

            Assert.AreSame(list, mockedView.Object.GetRelationships);
        }

        [Test]
        public void TeacherPresenter_Should_CallSetDropdown_When_Raise_Load()
        {
            var list = new List<Relationship>();

            var mockedView = new Mock<ITeacherView>();
            mockedView.SetupAllProperties();
            mockedView.Setup(v => v.SetDropdown());
            mockedView.SetupGet(v => v.Username).Returns("test");

            var mockedService = new Mock<IRelationshipService>();
            mockedService.SetupAllProperties();
            mockedService.Setup(s => s.Find(It.IsAny<string>())).Returns(list);

            var presenter = new TeacherPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());

            mockedView.Verify(v => v.SetDropdown(), Times.Once);
        }

        [Test]
        public void TeacherPresenter_Should_CallFind_When_Raise_Load()
        {
            var list = new List<Relationship>();

            var mockedView = new Mock<ITeacherView>();
            mockedView.SetupAllProperties();
            mockedView.Setup(v => v.SetDropdown());
            mockedView.SetupGet(v => v.Username).Returns("test");

            var mockedService = new Mock<IRelationshipService>();
            mockedService.SetupAllProperties();
            mockedService.Setup(s => s.Find(It.IsAny<string>())).Returns(list);

            var presenter = new TeacherPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());

            mockedService.Verify(s => s.Find(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void TeacherPresenter_Should_CallFind_When_Raise_AddTeacher()
        {
            var list = new List<Relationship>();

            var mockedView = new Mock<ITeacherView>();
            mockedView.SetupAllProperties();
            mockedView.Setup(v => v.SetDropdown());
            mockedView.SetupGet(v => v.Username).Returns("test");
            mockedView.SetupGet(v => v.TeacherUsername).Returns("test");
            mockedView.SetupGet(v => v.Subject).Returns("test");
            mockedView.SetupGet(v => v.Username).Returns("test");

            var mockedService = new Mock<IRelationshipService>();
            mockedService.SetupAllProperties();
            mockedService.Setup(s => s.Find(It.IsAny<string>())).Returns(list);
            mockedService.Setup(s => s.Add(It.IsAny<Relationship>()));

            var presenter = new TeacherPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.AddTeacher += null, new EventArgs());

            mockedService.Verify(s => s.Find(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void TeacherPresenter_Should_CallAdd_When_Raise_AddTeacher()
        {
            var list = new List<Relationship>();

            var mockedView = new Mock<ITeacherView>();
            mockedView.SetupAllProperties();
            mockedView.Setup(v => v.SetDropdown());
            mockedView.SetupGet(v => v.Username).Returns("test");
            mockedView.SetupGet(v => v.TeacherUsername).Returns("test");
            mockedView.SetupGet(v => v.Subject).Returns("test");
            mockedView.SetupGet(v => v.Username).Returns("test");

            var mockedService = new Mock<IRelationshipService>();
            mockedService.SetupAllProperties();
            mockedService.Setup(s => s.Find(It.IsAny<string>())).Returns(list);
            mockedService.Setup(s => s.Add(It.IsAny<Relationship>()));

            var presenter = new TeacherPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.AddTeacher += null, new EventArgs());

            mockedService.Verify(s => s.Add(It.IsAny<Relationship>()), Times.Once);
        }

        [Test]
        public void TeacherPresenter_Should_SetGetRelationships_When_Raise_AddTeacher()
        {
            var list = new List<Relationship>();

            var mockedView = new Mock<ITeacherView>();
            mockedView.SetupAllProperties();
            mockedView.Setup(v => v.SetDropdown());
            mockedView.SetupGet(v => v.Username).Returns("test");
            mockedView.SetupGet(v => v.TeacherUsername).Returns("test");
            mockedView.SetupGet(v => v.Subject).Returns("test");
            mockedView.SetupGet(v => v.Username).Returns("test");

            var mockedService = new Mock<IRelationshipService>();
            mockedService.SetupAllProperties();
            mockedService.Setup(s => s.Find(It.IsAny<string>())).Returns(list);
            mockedService.Setup(s => s.Add(It.IsAny<Relationship>()));

            var presenter = new TeacherPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.AddTeacher += null, new EventArgs());

            Assert.AreSame(list, mockedView.Object.GetRelationships);
        }

        [TestCase("English", "Английски език")]
        [TestCase("Music", "Музика")]
        public void TeacherPresenter_Should_CallTranslateSubject_When_Raise_Load(string english, string bulgarian)
        {
            var list = new List<Relationship>();

            var mockedView = new Mock<ITeacherView>();
            mockedView.SetupAllProperties();
            mockedView.Setup(v => v.SetDropdown());
            mockedView.SetupGet(v => v.Username).Returns("test");

            var mockedService = new Mock<IRelationshipService>();
            mockedService.SetupAllProperties();
            mockedService.Setup(s => s.Find(It.IsAny<string>())).Returns(list);

            var presenter = new TeacherPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());

            var list2 = new List<Relationship>();
            var item = new Relationship();
            item.Subject = english;

            list2.Add(item);

            presenter.TranslateSubject(list2);

            Assert.AreEqual(bulgarian, item.Subject);
        }
    }
}