using Task8.Entities;

namespace Task8.BLL.Interfaces
{
    public interface IBLL
    {
        Award CreateAward(string title);
        void EditTitle(string newTitle);
        void DeleteAward(Award award);
        Award GetAward(Award award);
        User CreateUser(int age, string name, DateTime birthDate);
        void EditName(string newName);
        void EditAge(int newAge);
        void EditDateOfBirth(DateTime newBirthDate);
        User GetUser();
        void DeleteUser(User user);
    }
}