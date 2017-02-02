using MyNotebooks.Data.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.DataModels.Tests
{
    [TestFixture]
    public class NotebookTests
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(100)]
        public void Notebook_Should_Set_Id(int id)
        {
            var notebook = new Notebook();

            notebook.Id = id;

            Assert.AreEqual(id, notebook.Id);
        }

        [TestCase("Gosho")]
        [TestCase("Pesho")]
        public void Notebook_Should_Set_Username(string username)
        {
            var notebook = new Notebook();

            notebook.Username = username;

            Assert.AreEqual(username, notebook.Username);
        }

        [TestCase("Math")]
        [TestCase("Informatics")]
        [TestCase("IT")]
        public void Notebook_Should_Set_Subject(string subject)
        {
            var notebook = new Notebook();

            notebook.Subject = subject;

            Assert.AreEqual(subject, notebook.Subject);
        }

        [TestCase("Classwork")]
        [TestCase("Homework")]
        public void Notebook_Should_Set_Type(string type)
        {
            var notebook = new Notebook();

            notebook.Type = type;

            Assert.AreEqual(type, notebook.Type);
        }

        [TestCase("Testing content")]
        [TestCase("Hello world")]
        [TestCase("Notebook content")]
        public void Notebook_Should_Set_Content(string content)
        {
            var notebook = new Notebook();

            notebook.Subject = content;

            Assert.AreEqual(content, notebook.Subject);
        }
    }
}
