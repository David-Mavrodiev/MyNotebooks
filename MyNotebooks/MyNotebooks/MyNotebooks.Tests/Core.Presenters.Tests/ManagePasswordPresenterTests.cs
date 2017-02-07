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
    public class ManagePasswordPresenterTests
    {
        [Test]
        public void ManagePasswordPresenter_Should_Initialize_A_Object()
        {
            var mockedView = new Mock<IManagePasswordView>();
            var presenter = new ManagePasswordPresenter(mockedView.Object);

            Assert.IsInstanceOf<ManagePasswordPresenter>(presenter);
        }
    }
}
