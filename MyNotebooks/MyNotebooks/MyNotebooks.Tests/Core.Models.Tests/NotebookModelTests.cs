using MyNotebooks.Core.Models;
using MyNotebooks.Data.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.Core.Models.Tests
{
    [TestFixture]
    public class NotebookModelTests
    {
        [Test]
        public void NotebookModel_Should_Set_Notebook()
        {
            var notebook = new Notebook();
            var model = new NotebookModel();
            model.Notebook = notebook;

            Assert.AreSame(notebook, model.Notebook);
        } 
    }
}
