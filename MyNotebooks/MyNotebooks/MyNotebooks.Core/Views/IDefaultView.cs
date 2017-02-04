using MyNotebooks.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace MyNotebooks.Core.Views
{
    public interface IDefaultView : IView<DefaultModel>
    {
        IDictionary<string, string> GetImages { get; set; }

        IDictionary<string, string> GetNotebooks { get; set; }

        int NumberOfNotebooks { get; set; }

        bool IsLogged { get; }

        bool UserIsInRole(string role);

        bool NotebooksVisible { get; set; }

        bool AboutVisible { get; set; }
    }
}
