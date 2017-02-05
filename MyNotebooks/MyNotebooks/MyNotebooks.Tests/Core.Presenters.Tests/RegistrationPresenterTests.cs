using Moq;
using MyNotebooks.Core.Presenters;
using MyNotebooks.Core.Views;
using MyNotebooks.Data.AccountServices.Contracts;
using MyNotebooks.DataModels.Contracts;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.Core.Presenters.Tests
{
    [TestFixture]
    public class RegistrationPresenterTests
    {
        [Test]
        public void RegistrationPresenter_Should_Initialize_A_Object()
        {
            var mockedView = new Mock<IRegistrationView>();
            var mockedService = new Mock<IUserService>();

            var presenter = new RegistrationPresenter(mockedView.Object, mockedService.Object);

            Assert.IsInstanceOf<RegistrationPresenter>(presenter);
        }

        [Test]
        public void RegistrationPresenter_Should_Call_AddRoleToUser_When_Successfuly_Register_A_User()
        {
            var signInManager = new Mock<IApplicationSignInManager>();
            signInManager.SetupAllProperties();
            signInManager.Setup(s => s.SignIn(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>())).Returns(true);

            var mockedUserManager = new Mock<IApplicationUserManager>();
            mockedUserManager.SetupAllProperties();
            mockedUserManager.Setup(u => u.CreateUser(It.IsAny<IUser>(), It.IsAny<string>())).Returns(true);

            var mockedView = new Mock<IRegistrationView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.Email).Returns("test");
            mockedView.SetupGet(v => v.Password).Returns("test");
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.SignInManager).Returns(signInManager.Object);
            mockedView.Setup(v => v.Redirect(It.IsAny<string>()));

            var mockedService = new Mock<IUserService>();
            mockedService.Setup(s => s.AddRoleToUser(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            var presenter = new RegistrationPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.RegisterUser += null, new EventArgs());

            mockedService.Verify(s => s.AddRoleToUser(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void RegistrationPresenter_Should_Call_SignIn_When_Successfuly_Register_A_User()
        {
            var signInManager = new Mock<IApplicationSignInManager>();
            signInManager.SetupAllProperties();
            signInManager.Setup(s => s.SignIn(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>())).Returns(true);

            var mockedUserManager = new Mock<IApplicationUserManager>();
            mockedUserManager.SetupAllProperties();
            mockedUserManager.Setup(u => u.CreateUser(It.IsAny<IUser>(), It.IsAny<string>())).Returns(true);

            var mockedView = new Mock<IRegistrationView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.Email).Returns("test");
            mockedView.SetupGet(v => v.Password).Returns("test");
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.SignInManager).Returns(signInManager.Object);
            mockedView.Setup(v => v.Redirect(It.IsAny<string>()));

            var mockedService = new Mock<IUserService>();
            mockedService.Setup(s => s.AddRoleToUser(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            var presenter = new RegistrationPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.RegisterUser += null, new EventArgs());

            signInManager.Verify(s => s.SignIn(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>()), Times.Once);
        }

        [Test]
        public void RegistrationPresenter_Should_Call_Redirect_When_Successfuly_Register_A_User()
        {
            var signInManager = new Mock<IApplicationSignInManager>();
            signInManager.SetupAllProperties();
            signInManager.Setup(s => s.SignIn(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>())).Returns(true);

            var mockedUserManager = new Mock<IApplicationUserManager>();
            mockedUserManager.SetupAllProperties();
            mockedUserManager.Setup(u => u.CreateUser(It.IsAny<IUser>(), It.IsAny<string>())).Returns(true);

            var mockedView = new Mock<IRegistrationView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.Email).Returns("test");
            mockedView.SetupGet(v => v.Password).Returns("test");
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.SignInManager).Returns(signInManager.Object);
            mockedView.Setup(v => v.Redirect(It.IsAny<string>()));

            var mockedService = new Mock<IUserService>();
            mockedService.Setup(s => s.AddRoleToUser(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            var presenter = new RegistrationPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.RegisterUser += null, new EventArgs());

            mockedView.Verify(v => v.Redirect(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void RegistrationPresenter_Should_Call_Set_ErrorMessageText_When_NotSuccessfuly_Register_A_User()
        {
            var signInManager = new Mock<IApplicationSignInManager>();
            signInManager.SetupAllProperties();
            signInManager.Setup(s => s.SignIn(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>())).Returns(true);

            var mockedUserManager = new Mock<IApplicationUserManager>();
            mockedUserManager.SetupAllProperties();
            mockedUserManager.Setup(u => u.CreateUser(It.IsAny<IUser>(), It.IsAny<string>())).Returns(false);

            var mockedView = new Mock<IRegistrationView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.Email).Returns("test");
            mockedView.SetupGet(v => v.Password).Returns("test");
            mockedView.SetupGet(v => v.UserManager).Returns(mockedUserManager.Object);
            mockedView.SetupGet(v => v.SignInManager).Returns(signInManager.Object);
            mockedView.Setup(v => v.Redirect(It.IsAny<string>()));

            var mockedService = new Mock<IUserService>();
            mockedService.Setup(s => s.AddRoleToUser(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            var presenter = new RegistrationPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.RegisterUser += null, new EventArgs());

            Assert.AreEqual("Your username or password is incorrect!", mockedView.Object.ErrorMessageText);
        }
    }
}