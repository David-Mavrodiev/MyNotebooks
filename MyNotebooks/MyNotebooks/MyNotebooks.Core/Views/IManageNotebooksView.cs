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
    public interface IManageNotebooksView : IView<ManageNotebooksModel>
    {
        List<Relationship> GetNotebooks { get; set; }

        string Username { get; }

        IDictionary<string, string> Titles { get; set; }
    }
}
