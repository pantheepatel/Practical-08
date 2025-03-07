using System;

namespace HospitalManagement
{
    class Patient : Person
    {
        // Additional properties specific to patients
        public string MedicalCondition { get; set; }
        public decimal BillAmount { get; set; }

        // Constructor to initialize patient details
        public Patient(int id, string name, int age, string contactNumber, string condition, decimal billAmount)
            : base(id, name, age, contactNumber)
        {
            MedicalCondition = condition;
            BillAmount = billAmount;
        }

        // Overriding DisplayDetails from Person class
        public override void DisplayDetails()
        {
            Console.WriteLine("------ Patient Details ------");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Contact: {ContactNumber}");
            Console.WriteLine($"Medical Condition: {MedicalCondition}");
            Console.WriteLine($"Bill Amount: {BillAmount}");
        }
    }
}
