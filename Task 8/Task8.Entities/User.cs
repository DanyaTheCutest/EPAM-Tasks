namespace Task8.Entities
{
    public class User
    {
        public Guid ID { get; }

        public string Name { get; }

        public int Age { get; }

        public DateTime DateOfBirth { get; }

        public User(string name, int age, DateTime dateOfBirth)
        {
            Name = name;
            Age = age;
            DateOfBirth = dateOfBirth;
            ID = Guid.NewGuid();
        }
    }
}