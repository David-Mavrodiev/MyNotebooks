using MyNotebooks.Core.Presenters.Contracts;
using MyNotebooks.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace MyNotebooks.Core.Presenters
{
    public class DefaultPresenter : Presenter<IDefaultView>, IDefaultPresenter
    {
        private IDictionary<string, string> subjectTitles;
        private const int numberOfNotebooks = 12;
        private IDictionary<string, string> images;
        private const string imagesDirectory = "Images";
        private const string notebooksDirectory = "Notebooks";
        private IDictionary<string, string> notebooksLinks;
        private IDefaultView view;

        public DefaultPresenter(IDefaultView view) : base(view)
        {
            this.view = view;
            this.view.Load += Load;
        }

        public void Load(object sender, EventArgs e)
        {
            this.view.NumberOfNotebooks = numberOfNotebooks;
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

            this.images = new Dictionary<string, string>();
            this.notebooksLinks = new Dictionary<string, string>();

            for (int i = 0; i < numberOfNotebooks; i++)
            {
                this.images.Add(this.subjectTitles.ElementAt(i).Key, string.Format("{0}/{1}.jpg", imagesDirectory, this.subjectTitles.ElementAt(i).Value));
                this.notebooksLinks.Add(this.subjectTitles.ElementAt(i).Key, string.Format("{0}/{1}", notebooksDirectory, this.subjectTitles.ElementAt(i).Value));
            }

            if (!this.view.IsLogged || (this.view.IsLogged && this.view.UserIsInRole("Teacher")))
            {
                this.view.NotebooksVisible = false;
                this.view.AboutVisible = true;
            }
            else if (this.view.IsLogged && this.view.UserIsInRole("Student"))
            {
                this.view.NotebooksVisible = true;
                this.view.AboutVisible = false;
            }
            this.view.GetImages = this.images;
            this.view.GetNotebooks = this.notebooksLinks;
        }
    }
}
