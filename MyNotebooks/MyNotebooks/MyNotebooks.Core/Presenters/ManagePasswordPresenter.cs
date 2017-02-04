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
    public class ManagePasswordPresenter : Presenter<IManagePasswordView>, IManagePasswordPresenter
    {
        public ManagePasswordPresenter(IManagePasswordView view) : base(view)
        {

        }
    }
}
