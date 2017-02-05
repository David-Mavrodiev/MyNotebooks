using Moq;
using MyNotebooks.Core.Presenters;
using MyNotebooks.Core.Views;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.Core.Presenters.Tests
{
    [TestFixture]
    public class DefaultPresenterTests
    {
        [Test]
        public void DefaultPresenter_Should_Initialize_A_Object()
        {
            var mockedView = new Mock<IDefaultView>();
            var presenter = new DefaultPresenter(mockedView.Object);

            Assert.IsInstanceOf<DefaultPresenter>(presenter);
        }

        [Test]
        public void DefaultPresenter_Should_Set_NumberOfNotebooks_When_ViewLoad_Is_Raised()
        {
            var mockedView = new Mock<IDefaultView>();
            mockedView.SetupAllProperties();

            var presenter = new DefaultPresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.IsTrue(mockedView.Object.NumberOfNotebooks > 0);
        }

        [Test]
        public void DefaultPresenter_Should_Set_GetImages_When_ViewLoad_Is_Raised()
        {
            var mockedView = new Mock<IDefaultView>();
            mockedView.SetupAllProperties();

            var presenter = new DefaultPresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.IsTrue(mockedView.Object.GetImages.Count > 0);
        }

        [Test]
        public void DefaultPresenter_Should_Set_GetNotebooks_When_ViewLoad_Is_Raised()
        {
            var mockedView = new Mock<IDefaultView>();
            mockedView.SetupAllProperties();

            var presenter = new DefaultPresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.IsTrue(mockedView.Object.GetNotebooks.Count > 0);
        }

        [Test]
        public void DefaultPresenter_Should_Set_AboutVisibleToTrueWhenNotLogged_When_ViewLoad_Is_Raised()
        {
            var mockedView = new Mock<IDefaultView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.IsLogged).Returns(false);

            var presenter = new DefaultPresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.IsTrue(mockedView.Object.AboutVisible == true);
        }

        [Test]
        public void DefaultPresenter_Should_Set_NotebooksVisibleToFalseWhenNotLogged_When_ViewLoad_Is_Raised()
        {
            var mockedView = new Mock<IDefaultView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.IsLogged).Returns(false);

            var presenter = new DefaultPresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.IsTrue(mockedView.Object.NotebooksVisible == false);
        }

        [Test]
        public void DefaultPresenter_Should_Set_AboutVisibleToTrueWhenLoggedLikeTeacher_When_ViewLoad_Is_Raised()
        {
            var mockedView = new Mock<IDefaultView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.IsLogged).Returns(true);
            mockedView.Setup(v =>v.UserIsInRole(It.Is<string>(s => s == "Teacher"))).Returns(true);

            var presenter = new DefaultPresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.IsTrue(mockedView.Object.AboutVisible == true);
        }

        [Test]
        public void DefaultPresenter_Should_Set_NotebookVisibleToFalseWhenLoggedLikeTeacher_When_ViewLoad_Is_Raised()
        {
            var mockedView = new Mock<IDefaultView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.IsLogged).Returns(true);
            mockedView.Setup(v => v.UserIsInRole(It.Is<string>(s => s == "Teacher"))).Returns(true);

            var presenter = new DefaultPresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.IsTrue(mockedView.Object.NotebooksVisible == false);
        }

        [Test]
        public void DefaultPresenter_Should_Set_NotebookVisibleToTrueWhenLoggedLikeStudent_When_ViewLoad_Is_Raised()
        {
            var mockedView = new Mock<IDefaultView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.IsLogged).Returns(true);
            mockedView.Setup(v => v.UserIsInRole(It.Is<string>(s => s == "Student"))).Returns(true);

            var presenter = new DefaultPresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.IsTrue(mockedView.Object.NotebooksVisible == true);
        }

        [Test]
        public void DefaultPresenter_Should_Set_AboutVisibleToFalseWhenLoggedLikeStudent_When_ViewLoad_Is_Raised()
        {
            var mockedView = new Mock<IDefaultView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.IsLogged).Returns(true);
            mockedView.Setup(v => v.UserIsInRole(It.Is<string>(s => s == "Student"))).Returns(true);

            var presenter = new DefaultPresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.IsTrue(mockedView.Object.AboutVisible == false);
        }
    }
}
