namespace StudentSystem.Context
{
    using System.Data.Entity;

    using StudentSystem.Migrations;
    using StudentSystem.Models;

    public class StudentSystemContext : DbContext
    {
        // Your context has been configured to use a 'Student' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'StudentSystem.StudentSystem.Models.Student' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Student' 
        // connection string in the application configuration file.
        public StudentSystemContext()
            : base("StudentSystem")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Homework> Homeworks { get; set; }
    }
}