namespace NewsSite.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using NewsSite.Migrations;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;

    public class NewsDbContext : IdentityDbContext<ApplicationUser>
    {
        public NewsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer( new MigrateDatabaseToLatestVersion<NewsDbContext, Configuration>());
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Like> Likes { get; set; }

        public static NewsDbContext Create()
        {
            return new NewsDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Article>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .HasMany(e => e.Likes)
                .WithMany(e => e.Articles)
                .Map(m => m.ToTable("ArticlesLikes").MapLeftKey("ArticleId").MapRightKey("LikesId"));

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Articles)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);
        }
    }
}