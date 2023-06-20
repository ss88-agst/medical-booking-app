namespace BlazorApp3.Shared
{
    public class Appointment
    {
        public static int index = 0;
        public int ID { get; set; }
        public string DoctorName { get; set; }
        public Patient patient { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientEmail { get; set; }
        public string PatientPhone { get; set; }
        public string VisitReason { get; set; }
        public DateTime AppointmentDate { get; set; }

        public Appointment(int ID, string doctorName, string patientFirstName, string patientLastName, string visitReason, DateTime appointmentDate)
        {
            this.ID = ID;
            this.DoctorName = doctorName;
            this.PatientFirstName = patientFirstName;
            this.PatientLastName = patientLastName;
            this.VisitReason = visitReason;
            this.AppointmentDate = appointmentDate;
        }

        public Appointment(int ID, string doctorName, Patient patient, string visitReason, DateTime appointmentDate)
        {
            this.ID = ID;
            this.patient = patient;
            this.DoctorName = doctorName;
            this.PatientFirstName = patient.patientFirstName;
            this.PatientLastName = patient.patientLastName;
            this.PatientEmail = patient.email;
            this.PatientPhone = patient.phone;
            this.VisitReason = visitReason;
            this.AppointmentDate = appointmentDate;
        }

        public static List<Appointment> SampleAppointments = new List<Appointment>() {
            new Appointment(index++,"Dr. Miller", Patient.samplePatients[0], "Vaccine", new DateTime(2022, 12, 23, 9, 30,0)),
            new Appointment(index++,"Dr. Miller", Patient.samplePatients[0], "Vaccine Follow-up", new DateTime(2022, 12, 25, 12, 0,0)),
            new Appointment(index++,"Dr. Miller", Patient.samplePatients[0], "Vaccine Follow-up", new DateTime(2022, 12, 19, 8, 30,0)),
            new Appointment(index++,"Dr. Miller", Patient.samplePatients[0], "Vaccine Follow-up", new DateTime(2022, 12, 19, 10, 30,0)),
            new Appointment(index++,"Dr. Miller", Patient.samplePatients[0], "Vaccine Follow-up", new DateTime(2022, 12, 19, 3, 30,0)),
            new Appointment(index++,"Dr. Black", Patient.samplePatients[0], "Vaccine Follow-up", new DateTime(2022, 12, 18, 10, 0,0)),
            new Appointment(index++,"Dr. Croteau", Patient.samplePatients[0], "Other Vaccine", new DateTime(2022, 12, 25, 2, 30,0)),
            new Appointment(index++,"Dr. Miller", Patient.samplePatients[2], "Stomachache", new DateTime(2022, 11, 15, 10, 00, 00)),
        new Appointment(index++,"Dr. Black", Patient.samplePatients[3], "Migraine", new DateTime(2022, 11, 16, 8, 00, 00)),
        new Appointment(index++,"Dr. Miller", Patient.samplePatients[0], "Migraine", new DateTime(2022, 12, 16, 8, 00, 00))
        };
    }
}



