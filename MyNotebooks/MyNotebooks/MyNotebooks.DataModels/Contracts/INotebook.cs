using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.DataModels.Contracts
{
    public interface INotebook
    {
        int Id { get; set; }

        string Username { get; set; }

        string Subject { get; set; }

        string Type { get; set; }

        string Content { get; set; }
    }
}
