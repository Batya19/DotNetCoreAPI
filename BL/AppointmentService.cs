using BL.InterfacesServices;
using BL.Validation;
using DL;
using DL.Entities;

namespace BL
{
    public class AppointmentService : IAppointmentService
    {
        private IDataContext _context;

        public AppointmentService(IDataContext context)
        {
            _context = context;
        }

        public void AddAppointment(int id, int babyId, int nurseId, DateTime appointmentDate)
        {
            AppointmentValidation.ValidateAppointmentId(id);
            AppointmentValidation.ValidateAppointmentDate(appointmentDate);

            var appointment = new Appointment
            {
                Id = id,
                BabyId = babyId,
                NurseId = nurseId,
                AppointmentDate = appointmentDate
            };

            _context.Appointments.Add(appointment);
            _context.SaveChanges();
        }

        public Appointment GetAppointmentById(int id)
        {
            AppointmentValidation.ValidateAppointmentId(id);
            return _context.Appointments.FirstOrDefault(a => a.Id == id);
        }

        public List<Appointment> GetAllAppointments()
        {
            return _context.Appointments.ToList();
        }

        public void RemoveAppointment(int id)
        {
            AppointmentValidation.ValidateAppointmentId(id);

            var appointment = GetAppointmentById(id);
            if (appointment != null)
                _context.Appointments.Remove(appointment);
            _context.SaveChanges();
        }

        public void UpdateAppointment(int id, int babyId, int nurseId, DateTime appointmentDate)
        {
            AppointmentValidation.ValidateAppointmentId(id);
            AppointmentValidation.ValidateAppointmentDate(appointmentDate);
            BabyValidation.ValidateBabyId(babyId);
            NurseValidation.ValidateNurseId(nurseId);

            var appointment = GetAppointmentById(id);
            if (appointment != null)
            {
                appointment.BabyId = babyId;
                appointment.NurseId = nurseId;
                appointment.AppointmentDate = appointmentDate;
            }
            _context.SaveChanges();
        }
    }
}
