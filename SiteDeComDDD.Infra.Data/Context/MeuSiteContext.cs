
using SiteDeComDDD.Domain.Entities;
using System.Data.Entity;

namespace SiteDeComDDD.Infra.Data.Context
{
    public class MeuSiteContext: DbContext
    {

        public MeuSiteContext()
            : base("MeuSiteStringDeConexao")
        {

        }

        public DbSet<Client> Cliente { get; set; }
    }
    
}
