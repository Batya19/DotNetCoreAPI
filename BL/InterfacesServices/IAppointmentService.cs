using DL.Entities;

namespace BL.InterfacesServices
{
    public interface IAppointmentService
    {
        void AddAppointment(int id, int babyId, int nurseId, DateTime appointmentDate);
        Appointment GetAppointmentById(int id);
        List<Appointment> GetAllAppointments();
        void RemoveAppointment(int id);
        void UpdateAppointment(int id, int babyId, int nurseId, DateTime appointmentDate);
    }
}
