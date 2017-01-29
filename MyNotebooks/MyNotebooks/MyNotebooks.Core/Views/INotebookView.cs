using MyNotebooks.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace MyNotebooks.Core.Views
{
    public interface INotebookView : IView<NotebookModel>
    {
        string Subject { get; set; }
        string Type { get; set; }
        string Username { get; }
        string Content { get; set; }
        event EventHandler<EventArgs> SaveChanges;
    }
}
