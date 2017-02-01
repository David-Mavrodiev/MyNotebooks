using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Core.Presenters.Contracts
{
    public interface ILoginPresenter
    {
        void Login(object sender, EventArgs e);
    }
}
