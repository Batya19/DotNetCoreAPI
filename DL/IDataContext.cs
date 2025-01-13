using DL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DL
{
    public interface IDataContext
    {
        DbSet<Appointment> Appointments { get; set; }
        DbSet<Nurse> Nurses { get; set; }
        DbSet<Baby> Babies { get; set; }

        public void SaveChanges();
    }
}
