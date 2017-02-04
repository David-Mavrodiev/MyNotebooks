using MyNotebooks.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Data.Contracts
{
    public interface IRelationshipRepository : IGenericRepository<Relationship>
    {
        void setContext(INotebookDbContext context);

        Relationship Find(string studentName, string subject, string teacherName);

        List<Relationship> Find(string studentName, string subject);

        List<Relationship> Find(string studentName);

        List<Relationship> FindByTeacher(string teacherName);
    }
}
