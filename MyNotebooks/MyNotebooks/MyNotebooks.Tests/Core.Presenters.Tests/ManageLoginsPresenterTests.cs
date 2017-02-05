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
    public class ManageLoginsPresenterTests
    {
        [Test]
        public void ManageLoginsPresenter_Should_Initialize_A_Object()
        {
            var mockedView = new Mock<IManageLoginsView>();
            var presenter = new ManageLoginsPresenter(mockedView.Object);

            Assert.IsInstanceOf<ManageLoginsPresenter>(presenter);
        }

        [Test]
        public void ManageLoginsPresenter_Should_Set_CanRemoveExternalLogins_To_True()
        {
            var mockedView = new Mock<IManageLoginsView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(10);

            var presenter = new ManageLoginsPresenter(mockedView.Object);
            mockedView.Raise(v => v.Load += null, new EventArgs());

            Assert.AreEqual(true, mockedView.Object.CanRemoveExternalLogins);
        }

        [Test]
        public void ManageLoginsPresenter_Should_Set_CanRemoveExternalLogins_To_False()
        {
            var mockedView = new Mock<IManageLoginsView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(0);

            var presenter = new ManageLoginsPresenter(mockedView.Object);
            mockedView.Raise(v => v.Load += null, new EventArgs());

            Assert.AreEqual(false, mockedView.Object.CanRemoveExternalLogins);
        }

        [Test]
        public void ManageLoginsPresenter_Should_Set_SuccessMessage_To_StringEmpty()
        {
            var mockedView = new Mock<IManageLoginsView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(0);

            var presenter = new ManageLoginsPresenter(mockedView.Object);
            mockedView.Raise(v => v.Load += null, new EventArgs());

            Assert.AreEqual(String.Empty, mockedView.Object.SuccessMessage);
        }

        [Test]
        public void ManageLoginsPresenter_Should_Set_SuccessMessageVisible_To_False()
        {
            var mockedView = new Mock<IManageLoginsView>();
            mockedView.SetupAllProperties();
            mockedView.SetupGet(v => v.GetLoginsCount).Returns(0);

            var presenter = new ManageLoginsPresenter(mockedView.Object);
            mockedView.Raise(v => v.Load += null, new EventArgs());

            Assert.AreEqual(false, mockedView.Object.SuccessMessageVisible);
        }
    }
}
