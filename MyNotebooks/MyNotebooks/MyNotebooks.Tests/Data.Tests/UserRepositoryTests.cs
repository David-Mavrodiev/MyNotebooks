using Moq;
using MyNotebooks.Data;
using MyNotebooks.Data.Repositories;
using MyNotebooks.DataModels.Models;
using MyNotebooks.Tests.Services.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.Data.Tests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        [Test]
        public void UserRepository_Should_Initialize_A_Object()
        {
            var repo = new UserRepository();

            Assert.IsInstanceOf<UserRepository>(repo);
        }

        [Test]
        public void UserRepository_Should_Set_A_Context()
        {
            var context = new MockedDbContext();
            var repo = new UserRepository();
            repo.setContext(context);

            Assert.AreSame(context, repo.Context);
        }

        [Test]
        public void UserRepository_Should_Add()
        {
            var context = new Mock<NotebooksDbContext>();
            context.Setup(c =>c.Users.Add(It.IsAny<User>()));

            var repo = new UserRepository();
            repo.setContext(context.Object);
            repo.Add(new User());

            context.Verify(c => c.Users.Add(It.IsAny<User>()), Times.Once);
        }

        [Test]
        public void UserRepository_Should_Delate()
        {
            var context = new Mock<NotebooksDbContext>();
            context.Setup(c => c.Users.Remove(It.IsAny<User>()));

            var repo = new UserRepository();
            repo.setContext(context.Object);
            repo.Delete(new User());
            
            context.Verify(c => c.Users.Remove(It.IsAny<User>()), Times.Once);
        }
    }
}
