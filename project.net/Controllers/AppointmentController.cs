using Microsoft.AspNetCore.Mvc;
using DL.Entities;
using BL.InterfacesServices;

namespace Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpPost]
        public void CreateAppointment([FromBody] Appointment appointment)
        {
            _appointmentService.AddAppointment(appointment.Id, appointment.BabyId, appointment.NurseId, appointment.AppointmentDate);
        }

        [HttpGet("{id}")]
        public Appointment GetAppointment(int id)
        {
            return _appointmentService.GetAppointmentById(id);
        }

        [HttpGet]
        public List<Appointment> GetAllAppointments()
        {
            return _appointmentService.GetAllAppointments();
        }

        [HttpDelete("{id}")]
        public void RemoveAppointment(int id)
        {
            _appointmentService.RemoveAppointment(id);
        }

        [HttpPut("{id}")]
        public void UpdateAppointment(int id, [FromBody] Appointment updatedAppointment)
        {
            _appointmentService.UpdateAppointment(id, updatedAppointment.BabyId, updatedAppointment.NurseId, updatedAppointment.AppointmentDate);
        }
    }
}
