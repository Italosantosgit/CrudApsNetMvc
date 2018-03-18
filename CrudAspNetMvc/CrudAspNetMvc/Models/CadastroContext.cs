using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudAspNetMvc.Models
{
    public class CadastroContext:DbContext
    {
        public CadastroContext():base("CadastroDB")
        {
            Database.SetInitializer<CadastroContext>(
                new CreateDatabaseIfNotExists<CadastroContext>());
            Database.Initialize(false);

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}