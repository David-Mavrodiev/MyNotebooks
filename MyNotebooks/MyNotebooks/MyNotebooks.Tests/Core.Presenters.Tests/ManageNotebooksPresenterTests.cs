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
    public class ManageNotebooksPresenterTests
    {
        [Test]
        public void ManageNotebooksPresenter_Should_Initialize_Object()
        {
            var mockedView = new Mock<IManageNotebooksView>();
            var mockedService = new Mock<IRelationshipService>();
            var presenter = new ManageNotebooksPresenter(mockedView.Object, mockedService.Object);

            Assert.IsInstanceOf<ManageNotebooksPresenter>(presenter);
        }

        [Test]
        public void ManageNotebooksPresenter_Should_SetTitles_When_Invokes_Load()
        {
            var mockedView = new Mock<IManageNotebooksView>();
            mockedView.SetupAllProperties();

            var mockedService = new Mock<IRelationshipService>();
            mockedService.Setup(s => s.FindByTeacher(It.IsAny<string>())).Returns(new List<Relationship>());

            var presenter = new ManageNotebooksPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());

            Assert.IsTrue(mockedView.Object.Titles != null && mockedView.Object.Titles.Count > 0);
        }

        [Test]
        public void ManageNotebooksPresenter_Should_Set_GetNotebooks_When_Invokes_Load()
        {
            var mockedView = new Mock<IManageNotebooksView>();
            mockedView.SetupAllProperties();
            var list = new List<Relationship>();
            var mockedService = new Mock<IRelationshipService>();
            mockedService.Setup(s => s.FindByTeacher(It.IsAny<string>())).Returns(list);

            var presenter = new ManageNotebooksPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());

            Assert.AreSame(list, mockedView.Object.GetNotebooks);
        }
        [TestCase("English", "Английски език")]
        [TestCase("Music", "Музика")]
        public void ManageNotebooksPresenter_Should_Translate_When_Call_Translate(string english, string bulgarian)
        {
            var item = new Relationship();
            item.Subject = english;
            
            var list = new List<Relationship>();
            list.Add(item);

            var mockedView = new Mock<IManageNotebooksView>();
            mockedView.SetupAllProperties();

            var mockedService = new Mock<IRelationshipService>();
            mockedService.SetupAllProperties();
            mockedService.Setup(s => s.FindByTeacher(It.IsAny<string>())).Returns(new List<Relationship>());

            var presenter = new ManageNotebooksPresenter(mockedView.Object, mockedService.Object);
            mockedView.Raise(v => v.Load += null, new EventArgs());
            presenter.TranslateSubject(list);
           
            Assert.AreEqual(bulgarian, item.Subject);
        }
    }
}
