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
    public class RelationshipTests
    {
        [Test]
        public void Relationship_Should_Initialize_A_Object()
        {
            var relationship = new Relationship();

            Assert.IsInstanceOf<Relationship>(relationship);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void Relationship_Should_Set_Id(int id)
        {
            var relationship = new Relationship();
            relationship.Id = id;

            Assert.AreEqual(id, relationship.Id);
        }

        [TestCase("Pesho")]
        [TestCase("Gosho")]
        [TestCase("Stamat")]
        public void Relationship_Should_Set_StudentName(string name)
        {
            var relationship = new Relationship();
            relationship.StudentName = name;

            Assert.AreEqual(name, relationship.StudentName);
        }

        [TestCase("IT")]
        [TestCase("Informatics")]
        [TestCase("Math")]
        public void Relationship_Should_Set_Subject(string subject)
        {
            var relationship = new Relationship();
            relationship.Subject = subject;

            Assert.AreEqual(subject, relationship.Subject);
        }

        [TestCase("Pesho")]
        [TestCase("Gosho")]
        [TestCase("Stamat")]
        public void Relationship_Should_Set_TeacherName(string name)
        {
            var relationship = new Relationship();
            relationship.TeacherName = name;

            Assert.AreEqual(name, relationship.TeacherName);
        }
    }
}
