namespace HospitalManagement
{
    sealed class HospitalRules
    {
        
        // validating age
        public static bool IsValidAge(int age)
        {
            return age >= 0 && age <= 120;
        }
        // validating phone number
        public static bool IsValidContactNumber(string contactNumber)
        {
            if (string.IsNullOrEmpty(contactNumber))
            {
                return false;
            }

            if (contactNumber.Length != 10)
            {
                return false;
            }

            if (!contactNumber.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }
    }

}
