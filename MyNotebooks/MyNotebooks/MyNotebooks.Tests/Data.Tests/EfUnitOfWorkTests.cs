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
    }
}
