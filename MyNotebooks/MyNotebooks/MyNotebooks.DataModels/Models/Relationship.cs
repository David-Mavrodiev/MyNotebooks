using MyNotebooks.DataModels.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.DataModels.Models
{
    public class Relationship : IRelationship
    {
        public int Id { get; set; }

        public string StudentName { get; set; }

        public string Subject { get; set; }

        public string TeacherName { get; set; }
    }
}
