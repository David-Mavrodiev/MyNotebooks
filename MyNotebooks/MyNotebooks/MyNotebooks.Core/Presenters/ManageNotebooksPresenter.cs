using MyNotebooks.Core.Presenters.Contracts;
using MyNotebooks.Core.Views;
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
    public class ManageNotebooksPresenter : Presenter<IManageNotebooksView>, IManageNotebooksPresenter
    {
        private IManageNotebooksView view;
        private IRelationshipService service;
        private IDictionary<string, string> subjectTitles;
        private List<Relationship> relationships;

        public ManageNotebooksPresenter(IManageNotebooksView view, IRelationshipService service) : base(view)
        {
            this.view = view;
            this.service = service;
            this.view.Load += Load;
        }

        public void  Load(object sender, EventArgs e)
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

            this.relationships = this.service.FindByTeacher(this.view.Username);
            TranslateSubject(this.relationships);
            this.view.GetNotebooks = this.relationships;
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
