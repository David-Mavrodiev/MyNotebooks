﻿using MyNotebooks.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNotebooks.DataModels.Models;

namespace MyNotebooks.Data.Repositories
{
    public class RelationshipRepository : IRelationshipRepository
    {
        public INotebookDbContext Context { get; set; }

        public RelationshipRepository()
        {

        }

        public void setContext(INotebookDbContext context)
        {
            this.Context = context;
        }

        public void Add(Relationship entity)
        {
            var list = this.Context.Relationships.Where(r => r.StudentName == entity.StudentName && r.Subject == entity.Subject).ToList();
            if (list.Count > 0)
            {
                list.ElementAt(0).TeacherName = entity.TeacherName;
            }
            else
            {
                this.Context.Relationships.Add(entity);
            }
        }

        public void Delete(Relationship entity)
        {
            this.Context.Relationships.Remove(entity);
        }

        public Relationship Find(string studentName, string subject, string teacherName)
        {
            var obj = this.Context.Relationships.Where(r => r.StudentName == studentName && r.Subject == subject && r.TeacherName == teacherName).SingleOrDefault();
            var copy = new Relationship()
            {
                StudentName = obj.StudentName,
                Subject = obj.Subject,
                TeacherName = obj.TeacherName
            };
            return copy;
        }

        public List<Relationship> Find(string studentName, string subject)
        {
            var list = this.Context.Relationships.Where(r => r.StudentName == studentName && r.Subject == subject).ToList();
            var copyList = list.Select(r => new Relationship() { StudentName = r.StudentName, Subject = r.Subject, TeacherName = r.TeacherName }).ToList();
            return copyList;
        }

        public List<Relationship> Find(string studentName)
        {
            var list = this.Context.Relationships.Where(r => r.StudentName == studentName).ToList();
            var copyList = list.Select(r => new Relationship() { StudentName = r.StudentName, Subject = r.Subject, TeacherName = r.TeacherName }).ToList();
            return copyList;
        }

        public List<Relationship> FindByTeacher(string teacherName)
        {
            var list = this.Context.Relationships.Where(r => r.TeacherName == teacherName).ToList();
            var copyList = list.Select(r => new Relationship() { StudentName = r.StudentName, Subject = r.Subject, TeacherName = r.TeacherName }).ToList();
            return copyList;
        }
    }
}
