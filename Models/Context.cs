using Microsoft.EntityFrameworkCore;

namespace MVC.Models
{
    public class Context :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=DBMVC;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CRS_Result> CRS_Results { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region relation
            // relationship between department and instructor
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Instructors)
                .WithOne(i => i.Department)
                .HasForeignKey(i => i.DepartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            //relationship between department and trainee

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Trainees)
                .WithOne(t => t.Department)
                .HasForeignKey(t => t.DepartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            //relationship between department and course
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Courses)
                .WithOne(c => c.Department)
                .HasForeignKey(c => c.DepartmentID)
                .OnDelete(DeleteBehavior.NoAction);

            //relationship between course and instructor
            modelBuilder.Entity<Instructor>()
                .HasOne(I => I.Course)
                .WithMany(C => C.Instructors)
                .HasForeignKey(C => C.CourceID)
                .OnDelete(DeleteBehavior.NoAction);


            //relationship between course and CRS_Result
            modelBuilder.Entity<Course>()
                .HasMany(c => c.CRS_Results)
                .WithOne(cr => cr.Course)
                .HasForeignKey(cr => cr.Course_ID)
                .OnDelete(DeleteBehavior.NoAction);


            //relationship between trainee and CRS_Result
            modelBuilder.Entity<Trainee>()
                .HasMany(t => t.CRS_Results)
                .WithOne(cr => cr.Trainee)
                .HasForeignKey(cr => cr.TraineeID)
                .OnDelete(DeleteBehavior.NoAction);


            #endregion

            
            modelBuilder.Entity<Department>().HasData(
                new Department { ID = 1, Name = "IT", Manager = "Ahmed" },
                new Department { ID = 2, Name = "HR", Manager = "Mohamed" }
                );
             
            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { ID = 1, Name = "Ali",Image ="/images/1.jpg", Salary = 5000, DepartmentID = 1, CourceID = 1 },
                new Instructor { ID = 2, Name = "Omar", Image ="/images/2.jpg", Salary = 6000, DepartmentID = 1, CourceID = 2 },
                new Instructor { ID = 3, Name = "Hassan", Image ="/images/3.jpg", Salary = 7000, DepartmentID = 2, CourceID = 3 }
                );

            modelBuilder.Entity<Trainee>().HasData(
                new Trainee { ID = 1, Name = "Sara", image ="/images/1.jpg", address = "Cairo",grade = 100, DepartmentID = 1 },
                new Trainee { ID = 2, Name = "Lina", image ="/images/2.jpg", address = "Giza", grade = 80, DepartmentID = 1 },
                new Trainee { ID = 3, Name = "Mona", image ="/images/3.jpg", address = "Alex", grade = 90, DepartmentID = 2 }
                );  

            modelBuilder.Entity<Course>().HasData(
                new Course { ID = 1, Name = "C#", DepartmentID = 1  ,Degree=100 ,MinDegree=50},
                new Course { ID = 2, Name = "Java", DepartmentID = 1, Degree=200, MinDegree=80 },
                new Course { ID = 3, Name = "Recruitment", DepartmentID = 2, Degree=300, MinDegree=70 }
                );


            modelBuilder.Entity<CRS_Result>().HasData(
                new CRS_Result { ID = 1, Degree = 90, Course_ID = 1, TraineeID = 1 },
                new CRS_Result { ID = 2, Degree = 80, Course_ID = 2, TraineeID = 2 },
                new CRS_Result { ID = 3, Degree = 70, Course_ID = 3, TraineeID = 3 }
                );
        }



    }
}
