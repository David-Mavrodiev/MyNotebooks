using MyNotebooks.Core.Models;
using MyNotebooks.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace MyNotebooks.Core.Views
{
    public interface ITeacherView : IView<TeacherModel>
    {
        List<Relationship> GetRelationships { get; set; }

        event EventHandler<EventArgs> AddTeacher;

        string Username { get; }

        string Subject { get; }

        string TeacherUsername { get; }

        IDictionary<string, string> Titles { get; set; }

        void SetDropdown();
    }
}
