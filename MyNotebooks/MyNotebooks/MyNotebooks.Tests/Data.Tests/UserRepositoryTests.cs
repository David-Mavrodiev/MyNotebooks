using MyNotebooks.Data.Repositories;
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
    }
}
