namespace HospitalManagement
{
    class ExceptionHandler
    {
        public class InvalidPatientException : Exception
        {
            public InvalidPatientException(string message) : base(message) { }
        }
        public class PatientNotFoundException : Exception
        {
            public PatientNotFoundException(string message) : base(message) { }
        }
    }
}
