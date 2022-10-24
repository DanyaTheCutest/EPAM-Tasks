using Task8.Entities;

namespace Task8.DAL.Json.Interfaces
{
    public interface IUser
    {
        User CreateUser(int age, string name, DateTime birthDate);
        void EditName(string newName);
        void EditAge(int newAge);
        void EditDateOfBirth(DateTime newBirthDate);
        User GetUser();
        void DeleteUser(User user);
    }
}