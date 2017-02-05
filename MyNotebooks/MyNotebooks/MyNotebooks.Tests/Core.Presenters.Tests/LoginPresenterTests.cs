using Moq;
using MyNotebooks.Core.Presenters;
using MyNotebooks.Core.Views;
using MyNotebooks.Data.AccountServices.Contracts;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.Core.Presenters.Tests
{
    [TestFixture]
    public class LoginPresenterTests
    {
        [Test]
        public void LoginPresenter_Should_Initialize_A_Object()
        {
            var mockedService = new Mock<IUserService>();
            var mockedView = new Mock<ILoginView>();
            var presenter = new LoginPresenter(mockedView.Object, mockedService.Object);

            Assert.IsInstanceOf<LoginPresenter>(presenter);
        }

        [Test]
        public void LoginPresenter_Should_Set_NavigateUrl_When_Initialize()
        {
            var mockedView = new Mock<ILoginView>();
            mockedView.SetupAllProperties();

            var mockedService = new Mock<IUserService>();
            var presenter = new LoginPresenter(mockedView.Object, mockedService.Object);

            Assert.AreEqual("Register", mockedView.Object.NavigateUrl);
        }

        [Test]
        public void LoginPresenter_Should_Call_Success_When_RiseLoginUser_And_LoginSuccess()
        {
            var mockedUserManager = new Mock<IApplicationSignInManager>();
            mockedUserManager.Setup(m => m.SignIn(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>())).Returns(true);
            
            var mockedView = new Mock<ILoginView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.IsPropertiesValid).Returns(true);
            mockedView.Setup(v => v.Success(It.IsAny<string>()));
            mockedView.SetupGet(v => v.SignInManager).Returns(mockedUserManager.Object);

            var mockedService = new Mock<IUserService>();
            var presenter = new LoginPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.LoginUser += null, new EventArgs());

            mockedView.Verify(v => v.Success(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void LoginPresenter_Should_Set_ErrorMessage_When_RiseLoginUser_And_LoginNotSuccess()
        {
            var mockedUserManager = new Mock<IApplicationSignInManager>();
            mockedUserManager.Setup(m => m.SignIn(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>())).Returns(false);

            var mockedView = new Mock<ILoginView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.IsPropertiesValid).Returns(true);
            mockedView.Setup(v => v.Success(It.IsAny<string>()));
            mockedView.SetupGet(v => v.SignInManager).Returns(mockedUserManager.Object);

            var mockedService = new Mock<IUserService>();
            var presenter = new LoginPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.LoginUser += null, new EventArgs());

            Assert.AreEqual("Invalid login attempt", mockedView.Object.ErrorMessageText);
        }

        [Test]
        public void LoginPresenter_Should_Set_ErrorMessageVisible_When_RiseLoginUser_And_LoginNotSuccess()
        {
            var mockedUserManager = new Mock<IApplicationSignInManager>();
            mockedUserManager.Setup(m => m.SignIn(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>())).Returns(false);

            var mockedView = new Mock<ILoginView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.IsPropertiesValid).Returns(true);
            mockedView.Setup(v => v.Success(It.IsAny<string>()));
            mockedView.SetupGet(v => v.SignInManager).Returns(mockedUserManager.Object);

            var mockedService = new Mock<IUserService>();
            var presenter = new LoginPresenter(mockedView.Object, mockedService.Object);

            mockedView.Raise(v => v.LoginUser += null, new EventArgs());

            Assert.AreEqual(true, mockedView.Object.ErrorTextVisible);
        }
    }
}
