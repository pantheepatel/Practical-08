namespace HospitalManagement
{
    abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string ContactNumber { get; set; }

        protected Person(int id, string name, int age, string contactNumber)
        {
            Id = id;
            Name = name;
            Age = age;
            ContactNumber = contactNumber;
        }

        public abstract void DisplayDetails();
    }
}
