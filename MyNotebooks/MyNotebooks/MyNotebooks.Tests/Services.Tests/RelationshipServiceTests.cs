using Moq;
using MyNotebooks.Data;
using MyNotebooks.Data.Contracts;
using MyNotebooks.DataModels.Models;
using MyNotebooks.Services.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.Services.Tests
{
    [TestFixture]
    public class RelationshipServiceTests
    {
        [Test]
        public void RelationshipService_Should_Set_Parameters()
        {
            var mockedRepository = new Mock<IRelationshipRepository>();
            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            var mockedDbContext = new MockedDbContext();

            var service = new RelationshipService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);

            Assert.IsInstanceOf<RelationshipService>(service); 
        }

        [Test]
        public void RelationshipService_Repo_Should_Call_SetContext()
        {
            var mockedRepository = new Mock<IRelationshipRepository>();
            mockedRepository.Setup(r => r.setContext(It.IsAny<INotebookDbContext>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            var mockedDbContext = new MockedDbContext();

            var service = new RelationshipService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);

            mockedRepository.Verify(r => r.setContext(It.IsAny<INotebookDbContext>()), Times.Once);
        }

        [Test]
        public void RelationshipService_Should_Call_RepoAdd_When_Call_ServiceAdd()
        {
            var mockedRepository = new Mock<IRelationshipRepository>();
            mockedRepository.Setup(r => r.Add(It.IsAny<Relationship>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            var mockedDbContext = new MockedDbContext();

            var service = new RelationshipService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.Add(new Relationship());

            mockedRepository.Verify(r => r.Add(It.IsAny<Relationship>()), Times.Once);
        }

        [Test]
        public void RelationshipService_Should_Call_UOWCommit_When_Call_ServiceAdd()
        {
            var mockedRepository = new Mock<IRelationshipRepository>();
            mockedRepository.Setup(r => r.Add(It.IsAny<Relationship>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new MockedDbContext();

            var service = new RelationshipService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.Add(new Relationship());

            mockedUnitOfWork.Verify(u => u.Commit(), Times.Once);
        }

        [Test]
        public void RelationshipService_Should_Call_RepoDelete_When_Call_ServiceDelete()
        {
            var mockedRepository = new Mock<IRelationshipRepository>();
            mockedRepository.Setup(r => r.Delete(It.IsAny<Relationship>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            
            var mockedDbContext = new MockedDbContext();

            var service = new RelationshipService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.Delete(new Relationship());

            mockedRepository.Verify(r => r.Delete(It.IsAny<Relationship>()), Times.Once);
        }

        [Test]
        public void RelationshipService_Should_Call_UOWCommit_When_Call_ServiceDelete()
        {
            var mockedRepository = new Mock<IRelationshipRepository>();
            mockedRepository.Setup(r => r.Delete(It.IsAny<Relationship>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new MockedDbContext();

            var service = new RelationshipService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.Delete(new Relationship());

            mockedUnitOfWork.Verify(u => u.Commit(), Times.Once);
        }

        [Test]
        public void RelationshipService_Should_Call_RepoFind1_When_Call_ServiceFind1()
        {
            var mockedRepository = new Mock<IRelationshipRepository>();
            mockedRepository.Setup(r => r.Find(It.IsAny<string>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new MockedDbContext();

            var service = new RelationshipService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.Find("Test");

            mockedRepository.Verify(r => r.Find(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void RelationshipService_Should_Call_RepoFind2_When_Call_ServiceFind2()
        {
            var mockedRepository = new Mock<IRelationshipRepository>();
            mockedRepository.Setup(r => r.Find(It.IsAny<string>(), It.IsAny<string>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new MockedDbContext();

            var service = new RelationshipService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.Find("Test", "Test");

            mockedRepository.Verify(r => r.Find(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void RelationshipService_Should_Call_RepoFind3_When_Call_ServiceFind3()
        {
            var mockedRepository = new Mock<IRelationshipRepository>();
            mockedRepository.Setup(r => r.Find(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new MockedDbContext();

            var service = new RelationshipService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.Find("Test", "Test", "Test");

            mockedRepository.Verify(r => r.Find(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void RelationshipService_Should_Call_RepoFind1Teacher_When_Call_ServiceFind1Teacher()
        {
            var mockedRepository = new Mock<IRelationshipRepository>();
            mockedRepository.Setup(r => r.FindByTeacher(It.IsAny<string>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new MockedDbContext();

            var service = new RelationshipService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.FindByTeacher("Test");

            mockedRepository.Verify(r => r.FindByTeacher(It.IsAny<string>()), Times.Once);
        }
    }
}
