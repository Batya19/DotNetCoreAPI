using System;

namespace BL.Validation
{
    public static class AppointmentValidation
    {
        public static void ValidateAppointmentId(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("id", "AppointmentId cannot be less than zero.");
            }
        }

        public static void ValidateAppointmentDate(DateTime appointmentDate)
        {
            if (appointmentDate < DateTime.Now)
            {
                throw new ArgumentException("Appointment date cannot be in the past.");
            }
        }
    }
}
