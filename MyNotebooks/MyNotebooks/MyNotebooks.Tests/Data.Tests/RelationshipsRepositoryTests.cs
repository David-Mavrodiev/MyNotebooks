using Moq;
using MyNotebooks.Data.Contracts;
using MyNotebooks.Data.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.Data.Tests
{
    [TestFixture]
    public class RelationshipsRepositoryTests
    {
        [Test]
        public void RelationshipRepository_Should_Set_DbContext()
        {
            var DbContextMock = new Mock<INotebookDbContext>();

            var repo = new RelationshipRepository();
            Assert.DoesNotThrow(() => repo.setContext(DbContextMock.Object));
        }

        [Test]
        public void RelationshipsRepository_Should_Throw_Exception()
        {
            var DbContextMock = new Mock<INotebookDbContext>();

            var repo = new RelationshipRepository();
            repo.setContext(DbContextMock.Object);

            Assert.Throws<ArgumentNullException>(() => repo.Find("test", "test2", "test3"));
        }
    }
}
