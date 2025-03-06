namespace HospitalManagement
{
    sealed class HospitalRules
    {
        // consultation fee  
        public const decimal CONSULTATION_FEE = 500.00m;

        // billing rules  
        public static readonly Dictionary<string, decimal> ServiceCharges = new(){
            { "General Checkup", 300.00m },
            { "Emergency", 1500.00m },
            { "Surgery", 50000.00m },
            { "ICU Admission", 10000.00m }
        };

        // checking age
        public static bool ValidatePatientAge(int age)
        {
            return age >= 0 && age <= 120;
        }

        // returning the charge according to service choosen
        public static decimal GetServiceCharge(string serviceName)
        {
            return ServiceCharges.ContainsKey(serviceName) ? ServiceCharges[serviceName] : 0m;
        }
    }

}
