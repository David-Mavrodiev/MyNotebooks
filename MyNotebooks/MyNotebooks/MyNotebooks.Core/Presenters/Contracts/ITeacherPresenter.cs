using MyNotebooks.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Core.Presenters.Contracts
{
    public interface ITeacherPresenter
    {
        void AddTeacher(object sender, EventArgs e);

        void TranslateSubject(List<Relationship> relations);

        void Load(object sender, EventArgs e);
    }
}
