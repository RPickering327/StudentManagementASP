using Ewart.Models.Courses;
using Ewart.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ewart.Models.Database
{
    public class EwartContext : IdentityDbContext<IdentityUser>
    {

        public EwartContext(DbContextOptions<EwartContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Baseuser", NormalizedName = "Baseuser".ToUpper() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Admin", NormalizedName = "Admin".ToUpper() });
        }

        //School settings e.g logo
        public DbSet<UserSettings> userSettings { get; set; }

        //Employees and students
        public DbSet<BaseUser> users { get; set; }
        public DbSet<Student> students { get; set; }


        //A course is a year group and can have many classes
        public DbSet<Course> courses { get; set; }
        public DbSet<IndividualSubject> classes { get; set; }
        public DbSet<TimeTable> timetables { get; set; }

    }
}
