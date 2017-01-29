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
        string Subject { get; }
        string Type { get; }
        string Username { get; }
        Notebook Notebook { get; }
        void SaveContent(string content);
        string GetContent();
    }
}
