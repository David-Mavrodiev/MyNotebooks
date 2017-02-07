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
    public class RegisterExternalLoginPresenterTests
    {
        [Test]
        public void RegisterExternalLoginPresenter__Should_Initialize_A_Object()
        {
            var mockedView = new Mock<IRegisterExternalLoginView>();
            var presenter = new RegisterExternalLoginPresenter(mockedView.Object);

            Assert.IsInstanceOf<RegisterExternalLoginPresenter>(presenter);
        }
    }
}
