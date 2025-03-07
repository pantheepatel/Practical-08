using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalManagement
{
    class PatientService : ExceptionHandler,IPatientCRUD
    {
        private List<Patient> patients = new List<Patient>();

        // Add a new patient
        public void AddPatient(Patient patient)
        {
            if (patient == null)
            {
                throw new InvalidPatientException("Invalid patient data.");
            }

            patients.Add(patient);
            Console.WriteLine($"Patient {patient.Name} added successfully.");
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
            Console.WriteLine($"Total Bill: {patient.BillAmount:C}");
        }
    }
}
