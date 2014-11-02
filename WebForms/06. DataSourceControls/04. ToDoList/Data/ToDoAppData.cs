namespace _04.ToDoList
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using _04.ToDoList.Migrations;

    public partial class ToDoAppData : DbContext
    {
        public ToDoAppData()
            : base("name=ToDoAppData")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ToDoAppData, Configuration>());
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Todos)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Todo>()
                .Property(e => e.Body)
                .IsUnicode(false);
        }
    }
}
