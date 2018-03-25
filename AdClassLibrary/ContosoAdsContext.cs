using System.Data.Entity;

namespace AdClassLibrary
{
    public class ContosoAdsContext : DbContext
    {
        public ContosoAdsContext() : base("name=AdContextConString")
        {
        }

        public ContosoAdsContext(string connString) : base(connString)
        {
        }

        public System.Data.Entity.DbSet<Ad> Ads { get; set; }
    
    }
}
