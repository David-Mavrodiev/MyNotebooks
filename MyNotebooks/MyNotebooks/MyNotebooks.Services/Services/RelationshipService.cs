using MyNotebooks.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNotebooks.DataModels.Models;
using MyNotebooks.Data.Contracts;
using MyNotebooks.Data;

namespace MyNotebooks.Services.Services
{
    public class RelationshipService : IRelationshipService
    {
        private IRelationshipRepository repository;
        private IUnitOfWork unitOfWork;
        private NotebooksDbContext context;

        public RelationshipService(IRelationshipRepository repository, IUnitOfWork unitOfWork, NotebooksDbContext context)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.context = context;

            this.repository.setContext(context);
            this.unitOfWork.setContext(context);
        }

        public void Add(Relationship entity)
        {
            this.repository.Add(entity);
            this.unitOfWork.Commit();
        }

        public void Delete(Relationship entity)
        {
            this.repository.Delete(entity);
            this.unitOfWork.Commit();
        }

        public List<Relationship> Find(string studentName)
        {
            return this.repository.Find(studentName);
        }

        public List<Relationship> Find(string studentName, string subject)
        {
            return this.repository.Find(studentName, subject);
        }

        public Relationship Find(string studentName, string subject, string teacherName)
        {
            return this.repository.Find(studentName, subject, teacherName);
        }

        public List<Relationship> FindByTeacher(string teacherName)
        {
            return this.repository.FindByTeacher(teacherName);
        }
    }
}
