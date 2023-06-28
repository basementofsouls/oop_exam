using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace load_button_card
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=card")
        {
        }

        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Storekeeper> Storekeeper { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Type)
                .IsUnicode(false);
        }
    }
}
