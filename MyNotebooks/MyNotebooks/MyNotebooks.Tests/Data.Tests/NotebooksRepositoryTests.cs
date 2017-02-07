using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Moq;
using MyNotebooks.Data.Contracts;
using MyNotebooks.Data.Models;
using MyNotebooks.Data.Repositories;
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
    public class NotebooksRepositoryTests
    {
        [Test]
        public void NotebooksRepository_Should_Initialize_A_Object()
        {
            var repo = new NotebooksRepository();

            Assert.IsInstanceOf<NotebooksRepository>(repo);
        }

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

        [Test]
        public void NotebooksRepository_Should_Call_ContextAdd_When_Call_Add()
        {
            var DbContextMock = new Mock<INotebookDbContext>();
            DbContextMock.Setup(c => c.Notebooks.Add(It.IsAny<Notebook>()));

            var repo = new NotebooksRepository();
            repo.setNotebookDbContext(DbContextMock.Object);
            repo.Add(new Notebook());

            DbContextMock.Verify(c => c.Notebooks.Add(It.IsAny<Notebook>()), Times.Once);
        }

        [Test]
        public void NotebooksRepository_Should_Call_Delete_When_Call_Delete()
        {
            var DbContextMock = new Mock<INotebookDbContext>();
            DbContextMock.Setup(c => c.Notebooks.Remove(It.IsAny<Notebook>()));

            var repo = new NotebooksRepository();
            repo.setNotebookDbContext(DbContextMock.Object);
            repo.Delete(new Notebook());

            DbContextMock.Verify(c => c.Notebooks.Remove(It.IsAny<Notebook>()), Times.Once);
        }

        [TestCase("test1")]
        [TestCase("test2")]
        public void NotebooksRepository_Should_UpdateContent_When_Call_Update(string text)
        {
            var DbContextMock = new Mock<INotebookDbContext>();
            DbContextMock.Setup(c => c.Notebooks.Add(It.IsAny<Notebook>()));

            var repo = new NotebooksRepository();
            repo.setNotebookDbContext(DbContextMock.Object);
            var notebook = new Notebook();
            repo.Update(notebook, text);

            Assert.AreEqual(text, notebook.Content);
        }

        [TestCase("test1")]
        [TestCase("test2")]
        public void NotebooksRepository_Should_UpdateContent_When_Call_Update_With_Object(object text)
        {
            var DbContextMock = new Mock<INotebookDbContext>();
            DbContextMock.Setup(c => c.Notebooks.Add(It.IsAny<Notebook>()));

            var repo = new NotebooksRepository();
            repo.setNotebookDbContext(DbContextMock.Object);
            var notebook = new Notebook();
            repo.Update(notebook, text);

            Assert.AreEqual(text, notebook.Content);
        }

        [Test]
        public void NotebooksRepository_Should_Call_Find_When_Call_Find()
        {
            var mockDbSet = new Mock<DbSet<Notebook>>();
            var DbContextMock = new Mock<INotebookDbContext>();
            var repo = new NotebooksRepository();
            repo.setNotebookDbContext(DbContextMock.Object);
            
            Assert.Throws<ArgumentNullException>(() => repo.Find("dsad", "fdsf", "dsfs"));
        }
    }
}
