using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace individual_project_bragin_sport.Models
{
    public partial class SportDb : DbContext
    {
        public SportDb()
            : base("name=SportDb")
        {
        }

        public virtual DbSet<account_level_> account_level_ { get; set; }
        public virtual DbSet<city_point_> city_point_ { get; set; }
        public virtual DbSet<goods_> goods_ { get; set; }
        public virtual DbSet<order_> order_ { get; set; }
        public virtual DbSet<C_pick_up_point__> C_pick_up_point__ { get; set; }
        public virtual DbSet<product_category_> product_category_ { get; set; }
        public virtual DbSet<produser_> produser_ { get; set; }
        public virtual DbSet<status_order_> status_order_ { get; set; }
        public virtual DbSet<suplier_> suplier_ { get; set; }
        public virtual DbSet<user_> user_ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<account_level_>()
                .HasMany(e => e.user_)
                .WithRequired(e => e.account_level_)
                .HasForeignKey(e => e.account_level)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<city_point_>()
                .HasMany(e => e.C_pick_up_point__)
                .WithRequired(e => e.city_point_)
                .HasForeignKey(e => e.city)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<goods_>()
                .HasMany(e => e.order_)
                .WithRequired(e => e.goods_)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_pick_up_point__>()
                .HasMany(e => e.order_)
                .WithRequired(e => e.C_pick_up_point__)
                .HasForeignKey(e => e.pick_up_point)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product_category_>()
                .HasMany(e => e.goods_)
                .WithRequired(e => e.product_category_)
                .HasForeignKey(e => e.product_category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<produser_>()
                .HasMany(e => e.goods_)
                .WithRequired(e => e.produser_)
                .HasForeignKey(e => e.producer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<status_order_>()
                .HasMany(e => e.order_)
                .WithRequired(e => e.status_order_)
                .HasForeignKey(e => e.status_order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<suplier_>()
                .HasMany(e => e.goods_)
                .WithRequired(e => e.suplier_)
                .HasForeignKey(e => e.supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user_>()
                .HasMany(e => e.order_)
                .WithOptional(e => e.user_)
                .HasForeignKey(e => e.fio_clienta);
        }
    }
}
