using MyNotebooks.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.Data.Tests
{
    [TestFixture]
    public class NotebooksDbContextTests
    {
        [Test]
        public void NotebooksDbContext_Should_Create()
        {
            var context = NotebooksDbContext.Create();

            Assert.IsInstanceOf<NotebooksDbContext>(context);
        }
    }
}
