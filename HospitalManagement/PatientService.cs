using static HospitalManagement.ExceptionHandler;

namespace HospitalManagement
{
    class PatientService : IPatientCRUD
    {
        private List<Patient> patients = new List<Patient>();

        // Add a new patient
        public void AddPatient(Patient patient)
        {
            try
            {
                if (patient == null)
                {
                    throw new InvalidPatientException("Details can not be null");
                }
                if (!HospitalRules.IsValidAge(patient.Age))
                {
                    throw new InvalidPatientException("Invalid age. Age must be between 0 and 120.");
                }
                if (!HospitalRules.IsValidContactNumber(patient.ContactNumber))
                {
                    throw new InvalidPatientException("Invalid contact number. It must be 10 digits.");
                }
                patients.Add(patient);
                Console.WriteLine($"Patient {patient.Name} added successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }



        // List all patients
        public void ListPatients()
        {
            if (patients.Count == 0)
            {
                Console.WriteLine("\nNo patients found.");
                return;
            }

            Console.WriteLine("\nPatient List:");
            foreach (var patient in patients)
            {
                patient.DisplayDetails();
            }
        }

        // Update patient details
        public void UpdatePatient(int id, string name = null, int? age = null, string contactNumber = null, string condition = null, decimal? billAmount = null)
        {
            var patient = patients.FirstOrDefault(p => p.Id == id);
            if (patient == null)
            {
                Console.WriteLine($"Patient with ID {id} not found.");
                return;
            }

            if (age.HasValue && !HospitalRules.IsValidAge(age.Value))
            {
                Console.WriteLine("Invalid age. Age must be between 0 and 120.");
                return;
            }

            if (!string.IsNullOrEmpty(contactNumber) && !HospitalRules.IsValidContactNumber(contactNumber))
            {
                Console.WriteLine("Invalid contact number. It must be 10 digits.");
                return;
            }

            if (!string.IsNullOrEmpty(name)) patient.Name = name;
            if (age.HasValue) patient.Age = age.Value;
            if (!string.IsNullOrEmpty(contactNumber)) patient.ContactNumber = contactNumber;
            if (!string.IsNullOrEmpty(condition)) patient.MedicalCondition = condition;
            if (billAmount.HasValue) patient.BillAmount = billAmount.Value;

            Console.WriteLine($"Patient {id} updated successfully.");
        }

        // Check patient billing-which is stored using Patient class
        public void CheckBilling(int id)
        {
            var patient = patients.FirstOrDefault(p => p.Id == id);
            if (patient == null)
            {
                Console.WriteLine($"Patient with ID {id} not found.");
                return;
            }

            Console.WriteLine($"\nBilling Details for {patient.Name}:");
            Console.WriteLine($"Total Bill: {patient.BillAmount}");
        }
    }
}
