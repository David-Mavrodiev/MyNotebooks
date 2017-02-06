using Moq;
using MyNotebooks.Data;
using MyNotebooks.Data.Contracts;
using MyNotebooks.Identity.AccountServices;
using MyNotebooks.Tests.Services.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.Data.Tests.AccountServices
{
    [TestFixture]
    public class UserServiceTests
    {
        [Test]
        public void UserService_Should_Initialize_A_Object()
        {
            var mockedRepository = new Mock<IUserRepository>();
            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            var mockedDbContext = new MockedDbContext();

            var service = new UserService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);

            Assert.IsInstanceOf<UserService>(service);
        }

        [Test]
        public void UserService_Initialization_Should_Call_Repo_SetDbContext()
        {
            var mockedRepository = new Mock<IUserRepository>();
            mockedRepository.SetupAllProperties();
            mockedRepository.Setup(r => r.setContext(It.IsAny<NotebooksDbContext>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            var mockedDbContext = new MockedDbContext();

            var service = new UserService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);

            mockedRepository.Verify(r => r.setContext(It.IsAny<NotebooksDbContext>()),Times.Once);
        }

        [Test]
        public void UserService_Initialization_Should_Call_UnitOfWork_SetDbContext()
        {
            var mockedRepository = new Mock<IUserRepository>();
            mockedRepository.SetupAllProperties();
            mockedRepository.Setup(r => r.setContext(It.IsAny<NotebooksDbContext>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.SetupAllProperties();
            mockedUnitOfWork.Setup(u => u.setContext(It.IsAny<NotebooksDbContext>()));

            var mockedDbContext = new MockedDbContext();

            var service = new UserService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);

            mockedUnitOfWork.Verify(u => u.setContext(It.IsAny<NotebooksDbContext>()), Times.Once);
        }

        [Test]
        public void UserService_CallFind_Should_Call_Repo_Find()
        {
            var mockedRepository = new Mock<IUserRepository>();
            mockedRepository.SetupAllProperties();
            mockedRepository.Setup(r => r.setContext(It.IsAny<NotebooksDbContext>()));
            mockedRepository.Setup(r => r.Find(It.IsAny<string>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.SetupAllProperties();
            mockedUnitOfWork.Setup(u => u.setContext(It.IsAny<NotebooksDbContext>()));

            var mockedDbContext = new MockedDbContext();

            var service = new UserService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.Find("test");

            mockedRepository.Verify(r => r.Find(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void UserService_CallAddRoleToUser_Should_Call_Repo_AddRoleToUser()
        {
            var mockedRepository = new Mock<IUserRepository>();
            mockedRepository.SetupAllProperties();
            mockedRepository.Setup(r => r.setContext(It.IsAny<NotebooksDbContext>()));
            mockedRepository.Setup(r => r.Find(It.IsAny<string>()));
            mockedRepository.Setup(r => r.AddRoleToUser(It.IsAny<string>(), It.IsAny<string>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.SetupAllProperties();
            mockedUnitOfWork.Setup(u => u.setContext(It.IsAny<NotebooksDbContext>()));

            var mockedDbContext = new MockedDbContext();

            var service = new UserService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.AddRoleToUser("test", "test");

            mockedRepository.Verify(r => r.AddRoleToUser(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void UserService_CallAddRoleToUser_Should_Call_Repo_AddClaimToUser()
        {
            var mockedRepository = new Mock<IUserRepository>();
            mockedRepository.SetupAllProperties();
            mockedRepository.Setup(r => r.setContext(It.IsAny<NotebooksDbContext>()));
            mockedRepository.Setup(r => r.Find(It.IsAny<string>()));
            mockedRepository.Setup(r => r.AddClaimToUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.SetupAllProperties();
            mockedUnitOfWork.Setup(u => u.setContext(It.IsAny<NotebooksDbContext>()));

            var mockedDbContext = new MockedDbContext();

            var service = new UserService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.AddRoleToUser("test", "test");

            mockedRepository.Verify(r => r.AddClaimToUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void UserService_CallAddRoleToUser_Should_Call_UnitOfWOrk_Commit()
        {
            var mockedRepository = new Mock<IUserRepository>();
            mockedRepository.SetupAllProperties();
            mockedRepository.Setup(r => r.setContext(It.IsAny<NotebooksDbContext>()));
            mockedRepository.Setup(r => r.Find(It.IsAny<string>()));
            mockedRepository.Setup(r => r.AddClaimToUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.SetupAllProperties();
            mockedUnitOfWork.Setup(u => u.setContext(It.IsAny<NotebooksDbContext>()));
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new MockedDbContext();

            var service = new UserService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.AddRoleToUser("test", "test");

            mockedUnitOfWork.Verify(u => u.Commit(), Times.Once);
        }

        [Test]
        public void UserService_CallAddClaimToUser_Should_Call_Repo_AddClaimToUser()
        {
            var mockedRepository = new Mock<IUserRepository>();
            mockedRepository.SetupAllProperties();
            mockedRepository.Setup(r => r.setContext(It.IsAny<NotebooksDbContext>()));
            mockedRepository.Setup(r => r.Find(It.IsAny<string>()));
            mockedRepository.Setup(r => r.AddClaimToUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.SetupAllProperties();
            mockedUnitOfWork.Setup(u => u.setContext(It.IsAny<NotebooksDbContext>()));
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new MockedDbContext();

            var service = new UserService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.AddClaimToUser("test", "test", "test");

            mockedRepository.Verify(r => r.AddClaimToUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void UserService_CallAddClaimToUser_Should_Call_UnitOfWork_Commit()
        {
            var mockedRepository = new Mock<IUserRepository>();
            mockedRepository.SetupAllProperties();
            mockedRepository.Setup(r => r.setContext(It.IsAny<NotebooksDbContext>()));
            mockedRepository.Setup(r => r.Find(It.IsAny<string>()));
            mockedRepository.Setup(r => r.AddClaimToUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.SetupAllProperties();
            mockedUnitOfWork.Setup(u => u.setContext(It.IsAny<NotebooksDbContext>()));
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new MockedDbContext();

            var service = new UserService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.AddClaimToUser("test", "test", "test");

            mockedUnitOfWork.Verify(u => u.Commit(), Times.Once);
        }

        [Test]
        public void UserService_CallAddClaimToUser_Should_Return_True()
        {
            var mockedRepository = new Mock<IUserRepository>();
            mockedRepository.SetupAllProperties();
            mockedRepository.Setup(r => r.setContext(It.IsAny<NotebooksDbContext>()));
            mockedRepository.Setup(r => r.Find(It.IsAny<string>()));
            mockedRepository.Setup(r => r.AddClaimToUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()));

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.SetupAllProperties();
            mockedUnitOfWork.Setup(u => u.setContext(It.IsAny<NotebooksDbContext>()));
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new MockedDbContext();

            var service = new UserService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            Assert.IsTrue(service.AddClaimToUser("test", "test", "test"));
        }

        [Test]
        public void UserService_CallContainsClaim_Should_Call_AddClaimToUser()
        {
            var mockedRepository = new Mock<IUserRepository>();
            mockedRepository.SetupAllProperties();
            mockedRepository.Setup(r => r.setContext(It.IsAny<NotebooksDbContext>()));
            mockedRepository.Setup(r => r.Find(It.IsAny<string>()));
            mockedRepository.Setup(r => r.AddClaimToUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()));
            mockedRepository.Setup(r => r.ContainsClaim(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.SetupAllProperties();
            mockedUnitOfWork.Setup(u => u.setContext(It.IsAny<NotebooksDbContext>()));
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new MockedDbContext();

            var service = new UserService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);
            service.ContainsClaim("test", "test", "test");

            mockedRepository.Verify(r => r.ContainsClaim(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [TestCase(true)]
        [TestCase(false)]
        public void UserService_CallContainsClaim_Should_ReturnCorrect_AddClaimToUser(bool value)
        {
            var mockedRepository = new Mock<IUserRepository>();
            mockedRepository.SetupAllProperties();
            mockedRepository.Setup(r => r.setContext(It.IsAny<NotebooksDbContext>()));
            mockedRepository.Setup(r => r.Find(It.IsAny<string>()));
            mockedRepository.Setup(r => r.AddClaimToUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()));
            mockedRepository.Setup(r => r.ContainsClaim(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(value);

            var mockedUnitOfWork = new Mock<IUnitOfWork>();
            mockedUnitOfWork.SetupAllProperties();
            mockedUnitOfWork.Setup(u => u.setContext(It.IsAny<NotebooksDbContext>()));
            mockedUnitOfWork.Setup(u => u.Commit());

            var mockedDbContext = new MockedDbContext();

            var service = new UserService(mockedRepository.Object, mockedUnitOfWork.Object, mockedDbContext);

            Assert.AreEqual(value, service.ContainsClaim("test", "test", "test"));
        }
    }
}
