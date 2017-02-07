using Moq;
using MyNotebooks.Data.Contracts;
using MyNotebooks.Data.Repositories;
using MyNotebooks.DataModels.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.Data.Tests
{
    [TestFixture]
    public class RelationshipsRepositoryTests
    {
        [Test]
        public void RelationshipRepository_Should_Initialize_A_Object()
        {
            var repo = new RelationshipRepository();

            Assert.IsInstanceOf<RelationshipRepository>(repo);
        }

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

        [Test]
        public void RelationshipRepository_Should_Call_Remove()
        {
            var DbContextMock = new Mock<INotebookDbContext>();
            DbContextMock.Setup(c => c.Relationships.Remove(It.IsAny<Relationship>()));

            var repo = new RelationshipRepository();
            repo.setContext(DbContextMock.Object);

            repo.Delete(new Relationship());

            DbContextMock.Verify(c => c.Relationships.Remove(It.IsAny<Relationship>()), Times.Once);
        }
    }
}
