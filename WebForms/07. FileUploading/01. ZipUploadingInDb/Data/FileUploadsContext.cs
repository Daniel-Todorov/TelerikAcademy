namespace _01.ZipUploadingInDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using _01.ZipUploadingInDb.Migrations;

    public partial class FileUploadsContext : DbContext
    {
        public FileUploadsContext()
            : base("name=FileUploadsContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FileUploadsContext, Configuration>());
        }

        public virtual DbSet<File> Files { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<File>()
                .Property(e => e.FileContent)
                .IsUnicode(false);
        }
    }
}
