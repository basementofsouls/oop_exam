using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Goods_DB
{
    public partial class ModelGoods : DbContext
    {
        public ModelGoods()
            : base("name=ModelGoods")
        {
        }

        public virtual DbSet<Goods> Goods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
