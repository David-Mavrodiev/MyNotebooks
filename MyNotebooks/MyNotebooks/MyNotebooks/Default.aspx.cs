using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyNotebooks
{
    public partial class _Default : Page
    {
        private IDictionary<string, string> subjectTitles;
        private const int numberOfNotebooks = 12;
        private IDictionary<string, string> images;
        private const string imagesDirectory = "Images";
        private const string notebooksDirectory = "Notebooks";
        private IDictionary<string, string> notebooksLinks;

        public IDictionary<string, string> GetImages
        {
            get
            {
                return this.images;
            }
        }

        public IDictionary<string, string> GetNotebooks
        {
            get
            {
                return this.notebooksLinks;
            }
        }

        public int NumberOfNotebooks
        {
            get
            {
                return numberOfNotebooks;
            }
        }

        public bool IsLogged
        {
            get
            {
                if (this.User.Identity.IsAuthenticated)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
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

            this.images = new Dictionary<string, string>();
            this.notebooksLinks = new Dictionary<string, string>();

            for (int i = 0; i < this.NumberOfNotebooks; i++)
            {
                this.images.Add(this.subjectTitles.ElementAt(i).Key, string.Format("{0}/{1}.jpg", imagesDirectory, this.subjectTitles.ElementAt(i).Value));
                this.notebooksLinks.Add(this.subjectTitles.ElementAt(i).Key, string.Format("{0}/{1}", notebooksDirectory, this.subjectTitles.ElementAt(i).Value));
            }

            if (!this.IsLogged || (this.IsLogged && User.IsInRole("Teacher")))
            {
                this.notebooks.Visible = false;
                this.about.Visible = true;
            }
            else if(this.IsLogged && User.IsInRole("Student"))
            {
                this.notebooks.Visible = true;
                this.about.Visible = false;
            }
        }
    }
}