using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Data.Models
{
    public class Notebook
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Subject { get; set; }

        public string Type { get; set; }

        public string Content { get; set; }
    }
}
