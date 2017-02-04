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
    public class RegisterExternalLoginPresenter : Presenter<IRegisterExternalLoginView>, IRegisterExternalLoginPresenter
    {
        public RegisterExternalLoginPresenter(IRegisterExternalLoginView view) : base(view)
        {

        }
    }
}
