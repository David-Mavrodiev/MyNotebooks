﻿using MyNotebooks.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Data
{
    public class NotebooksDbContext : DbContext
    {
        public NotebooksDbContext() : base("MyNotebooks")
        {

        }

        public virtual IDbSet<Notebook> Notebooks { get; set; }
    }
}
