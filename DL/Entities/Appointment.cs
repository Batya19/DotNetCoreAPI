namespace DL.Entities
{
    public class Appointment
    {

        public int Id { get; set; }
        public int BabyId { get; set; }
        public int NurseId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public Appointment() { }
        public Appointment(int id, int babyId, int nurseId, DateTime appointmentDate)
        {
            Id = id;
            BabyId = babyId;
            NurseId = nurseId;
            AppointmentDate = appointmentDate;
        }
    }
}
