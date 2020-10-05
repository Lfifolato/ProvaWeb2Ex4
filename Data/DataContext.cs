using ProvaWeb2Ex4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProvaWeb2Ex4.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Professor> Professors { get; set; }

    }
}