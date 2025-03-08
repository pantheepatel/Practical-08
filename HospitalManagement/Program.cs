namespace HospitalManagement
{
    class Program
    {
        static void Main()
        {
            PatientService patientService = new PatientService();

            // Adding hardcoded patients
            Patient patient1 = new Patient(1, "Panthee Patel", 20, "9876543210", "Flu", 500);
            Patient patient2 = new Patient(2, "Nehee Patel", 16, "0123456789", "Cold", 300);

            patientService.AddPatient(patient1);
            patientService.AddPatient(patient2);

            // Listing patients which are valid and added
            patientService.ListPatients();

            // Checking billing
            patientService.CheckBilling(1);

            // Updating patient details
            Console.WriteLine("\nUpdating Panthee's Age to 21...");
            patientService.UpdatePatient(1, age: 21);
            patientService.ListPatients(); // listing again to check new details

            // Testing invalid input
            Console.WriteLine("\nTrying to add an invalid patient...");
            patientService.AddPatient(null);
            Patient patient3 = new Patient(3, "Chetna Patel", 44, "0123456", "Cold", 300);
            patientService.AddPatient(patient3);
        }
    }
}
