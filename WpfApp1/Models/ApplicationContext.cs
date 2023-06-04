using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    internal class ApplicationContext :DbContext
    {
        public DbSet<AdressBook> AdressBooks { get; set; }
        public DbSet<DataAdressBook> DataAdresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Prog.db");   
        }
    }
}
