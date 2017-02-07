using Moq;
using MyNotebooks.Data;
using MyNotebooks.Data.UnitOfWorks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Tests.Data.Tests
{
    [TestFixture]
    public class EfUnitOfWorkTests
    {
        [Test]
        public void EfUnitOfWork_Should_Initialize_A_Object()
        {
            EfUnitOfWork unitOfWork = new EfUnitOfWork();

            Assert.IsInstanceOf<EfUnitOfWork>(unitOfWork);
        }

        [Test]
        public void EfUnitOfWork_Should_Throw_When_Not_SetContext_and_call_Commit()
        {
            EfUnitOfWork unitOfWork = new EfUnitOfWork();

            Assert.Throws<NullReferenceException>(() => unitOfWork.Commit());
        }

        [Test]
        public void EfUnitOfWork_Should_Throw_When_Not_SetContext_and_call_Dispose()
        {
            EfUnitOfWork unitOfWork = new EfUnitOfWork();

            Assert.Throws<NullReferenceException>(() => unitOfWork.Dispose());
        }

        [Test]
        public void EfUnitOfWork_Should_Not_Throw_When_Set_Context()
        {
            var context = new Mock<NotebooksDbContext>();
            EfUnitOfWork unitOfWork = new EfUnitOfWork();

            Assert.DoesNotThrow(() => unitOfWork.setContext(context.Object));
        }

        [Test]
        public void EfUnitOfWork_Commit_Should_Call_SaveChanges()
        {
            var context = new Mock<NotebooksDbContext>();
            context.Setup(c => c.SaveChanges());
            EfUnitOfWork unitOfWork = new EfUnitOfWork();
            unitOfWork.setContext(context.Object);
            unitOfWork.Commit();

            context.Verify(c => c.SaveChanges(), Times.Once);
        }
    }
}
