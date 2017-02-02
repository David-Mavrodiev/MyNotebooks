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
    public class NotebooksRepositoryTests
    {
        [Test]
        public void NotebooksRepository_Should_Not_Throw_When_SetContext()
        {
            var DbContextMock = new Mock<INotebookDbContext>();

            var repo = new NotebooksRepository();
            Assert.DoesNotThrow(() => repo.setNotebookDbContext(DbContextMock.Object));
        }

        [Test]
        public void NotebooksRepository_Should_Throw_Exception()
        {
            var DbContextMock = new Mock<INotebookDbContext>();
           
            var repo = new NotebooksRepository();
            repo.setNotebookDbContext(DbContextMock.Object);

            Assert.Throws<ArgumentNullException>(() => repo.Find("test", "test2", "test3"));
            
        }
    }
}
