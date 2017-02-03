using MyNotebooks.Core.Presenters.Contracts;
using MyNotebooks.Core.Views;
using MyNotebooks.Data;
using MyNotebooks.Data.Contracts;
using MyNotebooks.DataModels.Models;
using MyNotebooks.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace MyNotebooks.Core.Presenters
{
    public class TeacherPresenter : Presenter<ITeacherView>, ITeacherPresenter
    {
        private IDictionary<string, string> subjectTitles;
        private List<Relationship> relationships;
        private IRelationshipService service;
        private ITeacherView view;

        public TeacherPresenter(ITeacherView view, IRelationshipService service) : base(view)
        {
            this.view = view;
            this.service = service;
            this.view.Load += Load;
            this.view.AddTeacher += AddTeacher; 
        }

        public void Load(object sender, EventArgs e)
        {
            this.subjectTitles = new Dictionary<string, string>();

            this.subjectTitles.Add("Английски език", "English");
            this.subjectTitles.Add("Музика", "Music");
            this.subjectTitles.Add("Изобразително изкуство", "Draw");
            this.subjectTitles.Add("Български език и литература", "Bulgarian");
            this.subjectTitles.Add("История и цивилизации", "History");
            this.subjectTitles.Add("Психология и логика", "Psychology");
            this.subjectTitles.Add("Биология", "Biology");
            this.subjectTitles.Add("География", "Geography");
            this.subjectTitles.Add("Физика", "Physics");
            this.subjectTitles.Add("Химия", "Chemistry");
            this.subjectTitles.Add("Информатика", "Informatics");
            this.subjectTitles.Add("Математика", "Math");

            this.view.Titles = this.subjectTitles;

            this.relationships = this.service.Find(this.view.Username);
            this.TranslateSubject(this.relationships);
            this.view.GetRelationships = this.relationships;
            this.view.SetDropdown();
        }

        public void AddTeacher(object sender, EventArgs e)
        {
            var teacherName = this.view.TeacherUsername;
            var subject = this.view.Subject;
            var studentName = this.view.Username;

            Relationship relation = new Relationship()
            {
                TeacherName = teacherName,
                StudentName = studentName,
                Subject = subject
            };

            this.service.Add(relation);
            this.relationships = this.service.Find(this.view.Username);
            this.TranslateSubject(this.relationships);
            this.view.GetRelationships = this.relationships;
        }

        public void TranslateSubject(List<Relationship> relations)
        {
            for (int i = 0; i < relations.Count; i++)
            {
                relations.ElementAt(i).Subject = this.subjectTitles.FirstOrDefault(e => e.Value == relations.ElementAt(i).Subject).Key;
            }
        }
    }
}
