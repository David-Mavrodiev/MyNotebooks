using Moq;
using MyNotebooks.Data;
using MyNotebooks.Data.Contracts;
using MyNotebooks.Data.Models;
using MyNotebooks.DataModels.Models;
using MyNotebooks.Services.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.Services.Tests
{
    class MockedDbContext : NotebooksDbContext
    {
        
    }

    [TestFixture]
    public class NotebookServiceTests
    {
        [Test]
        public void NotebookService_Constructor_Should_Construct_Object_Successfully()
        {
            var mockedRepository = new Mock<INotebooksRepository>();
            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            var mockedDbContext = new Mock<INotebookDbContext>();

            var service = new NotebookService(mockedRepository.Object, mockedUnitOfWork.Object, new MockedDbContext());

            Assert.IsInstanceOf<NotebookService>(service);
        }

        [Test]
        public void NotebookService_Repo_Should_Call_SetContext()
        {
            var mockedRepository = new Mock<INotebooksRepository>();
            mockedRepository.Setup(r => r.setNotebookDbContext(It.IsAny<INotebookDbContext>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            var mockedDbContext = new MockedDbContext();

            var service = new NotebookService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);

            mockedRepository.Verify(r => r.setNotebookDbContext(It.IsAny<INotebookDbContext>()), Times.Once);
        }

        [TestCase("Informatics")]
        [TestCase("Math")]
        [TestCase("IT")]
        [TestCase("Biology")]
        public void NotebookService_Should_Set_Subject_Successfully(string subject)
        {
            var mockedRepository = new Mock<INotebooksRepository>();
            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            var mockedDbContext = new Mock<INotebookDbContext>();

            var service = new NotebookService(mockedRepository.Object, mockedUnitOfWork.Object, new MockedDbContext());

            service.Subject = subject;

            Assert.AreEqual(subject, service.Subject);
        }

        [TestCase("Classwork")]
        [TestCase("Homework")]
        public void NotebookService_Should_Set_Subject_Type(string type)
        {
            var mockedRepository = new Mock<INotebooksRepository>();
            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            var mockedDbContext = new Mock<INotebookDbContext>();

            var service = new NotebookService(mockedRepository.Object, mockedUnitOfWork.Object, new MockedDbContext());

            service.Type = type;

            Assert.AreEqual(type, service.Type);
        }

        [TestCase("Gosho")]
        [TestCase("Pesho")]
        [TestCase("Stamat")]
        [TestCase("Ivan")]
        public void NotebookService_Should_Set_Username_Successfully(string username)
        {
            var mockedRepository = new Mock<INotebooksRepository>();
            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            var mockedDbContext = new Mock<INotebookDbContext>();

            var service = new NotebookService(mockedRepository.Object, mockedUnitOfWork.Object, new MockedDbContext());

            service.Username = username;

            Assert.AreEqual(username, service.Username);
        }

        [Test]
        public void NotebookService_Should_ReturnNull_When_Try_To_Get_Notebook_Before_Initialization()
        {
            var mockedRepository = new Mock<INotebooksRepository>();
            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            var mockedDbContext = new Mock<INotebookDbContext>();

            var service = new NotebookService(mockedRepository.Object, mockedUnitOfWork.Object, new MockedDbContext());
            Assert.AreEqual(null, service.Notebook);
        }

        [Test]
        public void NotebookService_Should_Throw_When_Try_To_Get_Content_Before_Initialization()
        {
            var mockedRepository = new Mock<INotebooksRepository>();
            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            var mockedDbContext = new Mock<INotebookDbContext>();

            var service = new NotebookService(mockedRepository.Object, mockedUnitOfWork.Object, new MockedDbContext());
            Assert.Throws<NullReferenceException>(() => service.GetContent());
        }

        [TestCase("Test")]
        public void NotebookService_Should_return_Notebook_After_Initialization(string text)
        {
            var mockedRepository = new Mock<INotebooksRepository>();
            mockedRepository.Setup(r => r.Find(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .Returns(
                    new Notebook()
                    {
                        Id = 0,
                        Content = text,
                        Subject = text,
                        Type = text,
                        Username = text
                    });

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new Mock<INotebookDbContext>();

            var service = new NotebookService(mockedRepository.Object, mockedUnitOfWork.Object, new MockedDbContext());
            service.Initialize();

            Assert.IsInstanceOf<Notebook>(service.Notebook);
        }

        [TestCase("Test")]
        [TestCase("Test1")]
        [TestCase("Test2")]
        public void NotebookService_Should_Set_Notebook_After_Initialization(string text)
        {
            var mockedRepository = new Mock<INotebooksRepository>();
            mockedRepository.Setup(r => r.Find(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .Returns(
                    new Notebook()
                    {
                        Id = 0,
                        Content = text,
                        Subject = text,
                        Type = text,
                        Username = text
                    });

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new Mock<INotebookDbContext>();

            var service = new NotebookService(mockedRepository.Object, mockedUnitOfWork.Object, new MockedDbContext());
            service.Initialize();

            Assert.AreEqual(text, service.Notebook.Content);
            Assert.AreEqual(text, service.Notebook.Subject);
            Assert.AreEqual(text, service.Notebook.Type);
            Assert.AreEqual(text, service.Notebook.Username);
        }

        [TestCase("Test")]
        public void NotebookService_Should_Call_Commit_When_Initialize(string text)
        {
            var mockedRepository = new Mock<INotebooksRepository>();
            mockedRepository.Setup(r => r.Find(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .Returns(
                    new Notebook()
                    {
                        Id = 0,
                        Content = text,
                        Subject = text,
                        Type = text,
                        Username = text
                    });

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new Mock<INotebookDbContext>();

            var service = new NotebookService(mockedRepository.Object, mockedUnitOfWork.Object, new MockedDbContext());
            service.Initialize();

            mockedUnitOfWork.Verify(u => u.Commit(), Times.Once);
        }

        [TestCase("Test")]
        public void NotebookService_Should_Call_Find_When_Initialize(string text)
        {
            var mockedRepository = new Mock<INotebooksRepository>();
            mockedRepository.Setup(r => r.Find(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .Returns(
                    new Notebook()
                    {
                        Id = 0,
                        Content = text,
                        Subject = text,
                        Type = text,
                        Username = text
                    });

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new Mock<INotebookDbContext>();

            var service = new NotebookService(mockedRepository.Object, mockedUnitOfWork.Object, new MockedDbContext());
            service.Initialize();

            mockedRepository.Verify(r => r.Find(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [TestCase("Test")]
        public void NotebookService_Should_Call_Update_When_SaveContent(string text)
        {
            var mockedRepository = new Mock<INotebooksRepository>();
            mockedRepository.Setup(r => r.Find(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .Returns(
                    new Notebook()
                    {
                        Id = 0,
                        Content = text,
                        Subject = text,
                        Type = text,
                        Username = text
                    });

            mockedRepository.Setup(r => r.Update(It.IsAny<Notebook>(), It.IsAny<string>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new Mock<INotebookDbContext>();

            var service = new NotebookService(mockedRepository.Object, mockedUnitOfWork.Object, new MockedDbContext());

            service.Initialize();
            service.SaveContent(text);

            mockedRepository.Verify(r => r.Update(It.IsAny<Notebook>(), It.IsAny<string>()), Times.Once);
        }

        [TestCase("Test")]
        public void NotebookService_Should_Call_Commit_When_SaveContent(string text)
        {
            var mockedRepository = new Mock<INotebooksRepository>();
            mockedRepository.Setup(r => r.Find(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .Returns(
                    new Notebook()
                    {
                        Id = 0,
                        Content = text,
                        Subject = text,
                        Type = text,
                        Username = text
                    });

            mockedRepository.Setup(r => r.Update(It.IsAny<Notebook>(), It.IsAny<string>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new Mock<INotebookDbContext>();

            var service = new NotebookService(mockedRepository.Object, mockedUnitOfWork.Object, new MockedDbContext());

            service.Initialize();
            service.SaveContent(text);

            mockedUnitOfWork.Verify(u => u.Commit(), Times.AtLeast(2));
        }

        [TestCase("Test")]
        public void NotebookService_Should_Get_Content_When_Call_GetContent(string text)
        {
            var mockedRepository = new Mock<INotebooksRepository>();
            mockedRepository.Setup(r => r.Find(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .Returns(
                    new Notebook()
                    {
                        Id = 0,
                        Content = text,
                        Subject = text,
                        Type = text,
                        Username = text
                    });

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new Mock<INotebookDbContext>();

            var service = new NotebookService(mockedRepository.Object, mockedUnitOfWork.Object, new MockedDbContext());

            service.Initialize();
            Assert.AreEqual(text, service.GetContent());
        }
    }
}
