using DL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DL
{
    public class DataContext : DbContext, IDataContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Baby> Babies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=clinic_db");
        }

        public void SaveChanges()
        {
            base.SaveChanges();
        }

        //public static List<Nurse> Nurses { get; set; }
        //public static List<Baby> Babies { get; set; }
        //public static List<Appointment> Appointments { get; set; }

        //static DataContext()
        //{
        //    Nurses = new List<Nurse>
        //            {
        //                new Nurse()
        //                {
        //                    Id = 1,
        //                    Name = "Rachel",
        //                }
        //            };

        //    Babies = new List<Baby>
        //            {
        //                new Baby()
        //                {
        //                    Id = 1,
        //                    Name = "Yossy",
        //                    BirthDate = new DateTime(2021, 1, 1)
        //                }
        //    };

        //    Appointments = new List<Appointment>
        //            {
        //                new Appointment()
        //                {
        //                    Id = 1,
        //                    BabyId = 1,
        //                    NurseId = 1,
        //                    AppointmentDate = DateTime.Now
        //                }
        //};
        //}
    }
}