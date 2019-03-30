using System.Data.Entity;

namespace MVC_Parc.Models
{
    public class DataContext:DbContext

    {
        public DataContext() : base("DefaultConnection")
        {

        }
    }
}