using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Core.Presenters.Contracts
{
    public interface INotebookPresenter
    {
        void Load(object sender, EventArgs e);
        void SaveChanges(object sender, EventArgs e);
    }
}
