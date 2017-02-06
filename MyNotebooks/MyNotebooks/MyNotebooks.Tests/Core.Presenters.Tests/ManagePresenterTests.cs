using Moq;
using MyNotebooks.Core.Presenters;
using MyNotebooks.Core.Views;
using MyNotebooks.Identity.AccountServices.Contracts;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.Core.Presenters.Tests
{
    [TestFixture]
    public class ManagePresenterTests
    {
        [Test]
        public void ManagePresenter_Should_Initialize_A_Object()
        {
            var mockedView = new Mock<IManageView>();

            var presenter = new ManagePresenter(mockedView.Object);

            Assert.IsInstanceOf<ManagePresenter>(presenter);
        }

        [Test]
        public void ManagePresenter_Should_SetLoginsCount_When_Raise_Load()
        {
            var mockedUserManager = new Mock<IApplicationUserManager>();
            var mockedView = new Mock<IManageView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(2);

            var presenter = new ManagePresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.AreEqual(2, mockedView.Object.LoginsCount);
        }

        [Test]
        public void ManagePresenter_Should_Set_ChangePasswordVisible_WhenHasPasswordIsTrue_When_Raise_Load()
        {
            var mockedUserManager = new Mock<IApplicationUserManager>();
            var mockedView = new Mock<IManageView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(2);
            mockedView.SetupGet(v => v.HasPassword).Returns(true);

            var presenter = new ManagePresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.AreEqual(true, mockedView.Object.ChangePasswordVisible);
        }

        [Test]
        public void ManagePresenter_Should_Set_ChangePasswordVisibleToFalse_WhenHasPasswordIsFalse_When_Raise_Load()
        {
            var mockedUserManager = new Mock<IApplicationUserManager>();
            var mockedView = new Mock<IManageView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(2);
            mockedView.SetupGet(v => v.HasPassword).Returns(false);

            var presenter = new ManagePresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.AreEqual(false, mockedView.Object.ChangePasswordVisible);
        }

        [Test]
        public void ManagePresenter_Should_Set_CreatePasswordVisibleToTrue_WhenHasPasswordIsFalse_When_Raise_Load()
        {
            var mockedUserManager = new Mock<IApplicationUserManager>();
            var mockedView = new Mock<IManageView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(2);
            mockedView.SetupGet(v => v.HasPassword).Returns(false);

            var presenter = new ManagePresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.AreEqual(true, mockedView.Object.CreatePasswordVisible);
        }

        [Test]
        public void ManagePresenter_Should_Set_SuccessMsgVisibleToFalse_When_RequestQueryMessageIsNull_When_Raise_Load()
        {
            var mockedUserManager = new Mock<IApplicationUserManager>();
            var mockedView = new Mock<IManageView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(2);
            mockedView.SetupGet(v => v.HasPassword).Returns(false);
            mockedView.SetupGet(v => v.RequestQueryMessage).Returns("");

            var presenter = new ManagePresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.AreEqual(false, mockedView.Object.SuccessMessageVisible);
        }

        [Test]
        public void ManagePresenter_Should_Set_SuccessMsgVisibleToTrue_When_RequestQueryMessageIsNotNull_When_Raise_Load()
        {
            var mockedUserManager = new Mock<IApplicationUserManager>();
            var mockedView = new Mock<IManageView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(2);
            mockedView.SetupGet(v => v.HasPassword).Returns(false);
            mockedView.SetupGet(v => v.RequestQueryMessage).Returns("ChangePwdSuccess");

            var presenter = new ManagePresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.AreEqual(true, mockedView.Object.SuccessMessageVisible);
        }

        [Test]
        public void ManagePresenter_Should_Set_SuccessMsg_When_RequestQueryMessageIsChangePwdSuccess_When_Raise_Load()
        {
            var mockedUserManager = new Mock<IApplicationUserManager>();
            var mockedView = new Mock<IManageView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(2);
            mockedView.SetupGet(v => v.HasPassword).Returns(false);
            mockedView.SetupGet(v => v.RequestQueryMessage).Returns("ChangePwdSuccess");

            var presenter = new ManagePresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.AreEqual("Your password has been changed.", mockedView.Object.SuccessMessage);
        }

        [Test]
        public void ManagePresenter_Should_Set_SuccessMsg_When_RequestQueryMessageIsSetPwdSuccess_When_Raise_Load()
        {
            var mockedUserManager = new Mock<IApplicationUserManager>();
            var mockedView = new Mock<IManageView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(2);
            mockedView.SetupGet(v => v.HasPassword).Returns(false);
            mockedView.SetupGet(v => v.RequestQueryMessage).Returns("SetPwdSuccess");

            var presenter = new ManagePresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.AreEqual("Your password has been set.", mockedView.Object.SuccessMessage);
        }

        [Test]
        public void ManagePresenter_Should_Set_SuccessMsg_When_RequestQueryMessageIsRemoveLoginSuccess_When_Raise_Load()
        {
            var mockedUserManager = new Mock<IApplicationUserManager>();
            var mockedView = new Mock<IManageView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(2);
            mockedView.SetupGet(v => v.HasPassword).Returns(false);
            mockedView.SetupGet(v => v.RequestQueryMessage).Returns("RemoveLoginSuccess");

            var presenter = new ManagePresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.AreEqual("The account was removed.", mockedView.Object.SuccessMessage);
        }

        [Test]
        public void ManagePresenter_Should_Set_SuccessMsg_When_RequestQueryMessageIsAddPhoneNumberSuccess_When_Raise_Load()
        {
            var mockedUserManager = new Mock<IApplicationUserManager>();
            var mockedView = new Mock<IManageView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(2);
            mockedView.SetupGet(v => v.HasPassword).Returns(false);
            mockedView.SetupGet(v => v.RequestQueryMessage).Returns("AddPhoneNumberSuccess");

            var presenter = new ManagePresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.AreEqual("Phone number has been added", mockedView.Object.SuccessMessage);
        }

        [Test]
        public void ManagePresenter_Should_Set_SuccessMsg_When_RequestQueryMessageIsRemovePhoneNumberSuccess_When_Raise_Load()
        {
            var mockedUserManager = new Mock<IApplicationUserManager>();
            var mockedView = new Mock<IManageView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(2);
            mockedView.SetupGet(v => v.HasPassword).Returns(false);
            mockedView.SetupGet(v => v.RequestQueryMessage).Returns("RemovePhoneNumberSuccess");

            var presenter = new ManagePresenter(mockedView.Object);

            mockedView.Raise(v => v.Load += null, new EventArgs());
            Assert.AreEqual("Phone number was removed", mockedView.Object.SuccessMessage);
        }
    }
}
