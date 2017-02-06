using MyNotebooks.DataModels.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.DataModels.Tests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void User_Should_Initialize_A_Object()
        {
            var user = new User();

            Assert.IsInstanceOf<User>(user);
        }

        [TestCase("Gosho")]
        [TestCase("Pesho")]
        [TestCase("Stamat")]
        public void User_Should_Set_A_Username(string name)
        {
            var user = new User();
            user.UserName = name;

            Assert.AreEqual(name, user.UserName);
        }

        [TestCase("Taina")]
        [TestCase("Sicret")]
        [TestCase("test")]
        public void User_Should_Set_A_PassHash(string passHash)
        {
            var user = new User();
            user.PasswordHash = passHash;

            Assert.AreEqual(passHash, user.PasswordHash);
        }
    }
}
