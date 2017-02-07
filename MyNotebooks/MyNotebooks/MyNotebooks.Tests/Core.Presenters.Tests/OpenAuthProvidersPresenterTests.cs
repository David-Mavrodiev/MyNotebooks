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
    public class OpenAuthProvidersPresenterTests
    {
        [Test]
        public void OpenAuthProvidersPresenter_Should_Initialize_A_Object()
        {
            var mockedView = new Mock<IOpenAuthProvidersView>();
            var presenter = new OpenAuthProvidersPresenter(mockedView.Object);

            Assert.IsInstanceOf<OpenAuthProvidersPresenter>(presenter);
        }
    }
}
