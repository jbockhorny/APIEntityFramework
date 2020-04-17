using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace APIEntityFramework.Models
{
    public class DbContexto : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            var config = "";
            try
            {
                config = ConfigurationManager.ConnectionStrings["config"].ConnectionString;
            }
            catch
            {
                config = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=avanade_aula;Data Source=WIN-VWQVJHQQJK\SQLEXPRESS";
            }
            optionsBuilder.UseSqlServer(config);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}