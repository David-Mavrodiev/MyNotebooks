using MyNotebooks.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Services.Contracts
{
    public interface IRelationshipService
    {

        Relationship Find(string studentName, string subject, string teacherName);

        List<Relationship> Find(string studentName, string subject);

        List<Relationship> Find(string studentName);

        void Add(Relationship entity);

        void Delete(Relationship entity);
    }
}
