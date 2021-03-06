using WstrzykiwanieSerwisów.Models;
using Microsoft.EntityFrameworkCore;
using Models.EntityModels;

namespace WstrzykiwanieSerwisów.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }

        public DbSet<Person> Person { get; set; }

        public DbSet<Address> Address { get; set; }
    }


}


