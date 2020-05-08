using System;
using System.Data.Entity;
using System.Linq;

namespace DBorder
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public class OrderContext : DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderContext>());
            DbConfiguration.SetConfiguration(new MySql.Data.EntityFramework.MySqlEFConfiguration());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}