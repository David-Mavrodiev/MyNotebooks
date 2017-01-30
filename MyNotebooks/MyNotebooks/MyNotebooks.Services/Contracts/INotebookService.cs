using MyNotebooks.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Services.Contracts
{
    public interface INotebookService
    {
        string Subject { get; set; }
        string Type { get; set; }
        string Username { get; set; }
        Notebook Notebook { get; }
        void SaveContent(string content);
        string GetContent();
        void Initialize();
    }
}
