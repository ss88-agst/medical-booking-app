namespace BlazorApp3.Shared
{
    public class Patient
    {
        public string patientFirstName { get; set; }
        public string patientLastName { get; set; }
        public DateTime dob { get; set; }
        public string email { get; set; }

        public string phone { get; set; }

        public string usualDoctor { get; set; }

        public Patient(string doctorName, string patientFirstName, string patientLastName, string email, string phone, DateTime dob)
        {
            this.usualDoctor = doctorName;
            this.patientFirstName = patientFirstName;
            this.patientLastName = patientLastName;
            this.dob = dob;
            this.phone = phone;
            this.email = email;
        }

        public Patient()
        {
            this.usualDoctor = "";
            this.patientFirstName = "";
            this.patientLastName = "";
            this.email = "";
            this.phone = "";
            this.dob = new DateTime();
        }


        public static Patient patientNotFoundReference = new Patient();

        //public static Patient[] samplePatients = {
        //    new Patient("Dr. Miller", "Sarah", "Gomez", "sarahgomez@gmail.com","855-444-9996", new DateTime(2000, 11, 15)),
        //    new Patient("Dr. Black", "Evan", "Striker", "es@gmail.com","403-777-6668", new DateTime(2003, 1, 17)),
        //    new Patient("Dr. Miller", "Sarah", "Stor", "ss@gmail.com","403-123-4567", new DateTime(2002, 4, 4)),
        //    new Patient("Dr. Black", "Emilia", "Allen", "ea@gmail.com","403-456-7890", new DateTime(2001, 3, 3))
        //};

        public static List<Patient> samplePatients = new List<Patient>() {
            new Patient("Dr. Miller", "Sarah", "Gomez", "sarahgomez@gmail.com","855-444-9996", new DateTime(2000, 11, 15)),
            new Patient("Dr. Black", "Evan", "Striker", "es@gmail.com","403-777-6668", new DateTime(2003, 1, 17)),
            new Patient("Dr. Miller", "Sarah", "Stor", "ss@gmail.com","403-123-4567", new DateTime(2002, 4, 4)),
            new Patient("Dr. Black", "Emilia", "Allen", "ea@gmail.com","403-456-7890", new DateTime(2001, 3, 3))
        };
    }
}
