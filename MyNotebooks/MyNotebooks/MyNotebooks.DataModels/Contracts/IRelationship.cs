using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.DataModels.Contracts
{
    public interface IRelationship
    {
        string StudentName { get; set; }
        string TeacherName { get; set; }
        string Subject { get; set; }
    }
}
