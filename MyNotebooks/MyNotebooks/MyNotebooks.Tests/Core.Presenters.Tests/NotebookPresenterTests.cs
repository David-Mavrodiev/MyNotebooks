using Moq;
using MyNotebooks.Core.Presenters;
using MyNotebooks.Core.Views;
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
    public class NotebookPresenterTests
    {
        [Test]
        public void NotebookPresenter_Should_Initialize_A_Object()
        {
            var mockedView = new Mock<INotebookView>();
            var mockedService = new Mock<INotebookService>();
            var presenter = new NotebookPresenter(mockedView.Object, mockedService.Object);

            Assert.IsInstanceOf<NotebookPresenter>(presenter);
        }

        [Test]
        public void NotebookPresenter_Constructor_Should_Call_Service_Initialize()
        {
            var mockedView = new Mock<INotebookView>();
            var mockedService = new Mock<INotebookService>();

            mockedService.Setup(s => s.Initialize());

            var presenter = new NotebookPresenter(mockedView.Object, mockedService.Object);

            mockedService.Verify(s => s.Initialize(), Times.Once);
        }

        [TestCase("Informatics")]
        [TestCase("IT")]
        [TestCase("Math")]
        public void NotebookPresenter_Constructor_Should_Set_Service_Subject(string subject)
        {
            var mockedView = new Mock<INotebookView>();
            mockedView.SetupGet(v => v.Subject).Returns(subject);

            var mockedService = new Mock<INotebookService>();
            mockedService.SetupAllProperties();

            var presenter = new NotebookPresenter(mockedView.Object, mockedService.Object);

            Assert.AreEqual(subject, mockedService.Object.Subject);
        }

        [TestCase("Classwork")]
        [TestCase("Homework")]
        public void NotebookPresenter_Constructor_Should_Set_Service_Type(string type)
        {
            var mockedView = new Mock<INotebookView>();
            mockedView.SetupGet(v => v.Type).Returns(type);

            var mockedService = new Mock<INotebookService>();
            mockedService.SetupAllProperties();

            var presenter = new NotebookPresenter(mockedView.Object, mockedService.Object);

            Assert.AreEqual(type, mockedService.Object.Type);
        }

        [TestCase("Pesho")]
        [TestCase("Gosho")]
        [TestCase("Stamat")]
        public void NotebookPresenter_Constructor_Should_Set_Service_Username(string username)
        {
            var mockedView = new Mock<INotebookView>();
            mockedView.SetupGet(v => v.Username).Returns(username);

            var mockedService = new Mock<INotebookService>();
            mockedService.SetupAllProperties();

            var presenter = new NotebookPresenter(mockedView.Object, mockedService.Object);

            Assert.AreEqual(username, mockedService.Object.Username);
        }

        [TestCase("TestCase1")]
        [TestCase("TestCase2")]
        [TestCase("TestCase3")]
        public void NotebookPresenter_Raise_Load_Should_Call_Presenter_Load(string text)
        {
            var mockedView = new Mock<INotebookView>();
            mockedView.SetupAllProperties();
            mockedView.Object.Content = "";

            var mockedService = new Mock<INotebookService>();
            mockedService.Setup(s => s.GetContent()).Returns(text);

            var presenter = new NotebookPresenter(mockedView.Object, mockedService.Object);
            mockedView.Raise(v => v.Load += null, new EventArgs());
            
            Assert.AreEqual(text, mockedView.Object.Content);
        }

        [Test]
        public void NotebookPresenter_Raise_Load_Should_Call_GetContent()
        {
            var mockedView = new Mock<INotebookView>();
            mockedView.SetupAllProperties();
            mockedView.Object.Content = "";

            var mockedService = new Mock<INotebookService>();
            mockedService.Setup(s => s.GetContent()).Returns("test");

            var presenter = new NotebookPresenter(mockedView.Object, mockedService.Object);
            mockedView.Raise(v => v.Load += null, new EventArgs());

            mockedService.Verify(s => s.GetContent(), Times.Once);
        }

        [Test]
        public void NotebookPresenter_Raise_Load_Should_Call_Presenter_SaveChanges()
        {
            var mockedView = new Mock<INotebookView>();
            mockedView.SetupAllProperties();

            var mockedService = new Mock<INotebookService>();
            mockedService.Setup(s => s.SaveContent(It.IsAny<string>()));

            var presenter = new NotebookPresenter(mockedView.Object, mockedService.Object);
            mockedView.Raise(v => v.SaveChanges += null, new EventArgs());

            mockedService.Verify(s => s.SaveContent(It.IsAny<string>()), Times.Once);
        }
    }
}
