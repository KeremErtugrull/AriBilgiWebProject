using AriBilgiWebProject.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AriBilgiWebProject.DAL
{
    public partial class NinicoDbModel : DbContext
    {
        public NinicoDbModel()
            : base("name=NinicoDbEntities")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Categories)
                .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<Images>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Images>()
                .Property(e => e.PicUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Tags>()
                .Property(e => e.TagName)
                .IsUnicode(false);
        }
    }
}
