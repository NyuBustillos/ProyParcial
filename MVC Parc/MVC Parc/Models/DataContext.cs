using System.Data.Entity;

namespace MVC_Parc.Models
{
    public class DataContext:DbContext

    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC_Parc.Models.Product> Products { get; set; }
    }
}