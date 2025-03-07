namespace HospitalManagement
{
    interface IPatientCRUD
    {
        void AddPatient(Patient patient);
        void ListPatients();
        void UpdatePatient(int id, string name = null, int? age = null, string contactNumber = null, string condition = null, decimal? billAmount = null);
        void CheckBilling(int id);
    }
}
