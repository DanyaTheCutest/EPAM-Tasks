using Task8.DAL.Json.Interfaces;
using Task8.Entities;

namespace Task8.DAL.Json
{
    public class DALJson : IAward, IUser
    {

        public DALJson()
        {

        }
        public Award CreateAward(string title)
        {
            throw new NotImplementedException();
        }

        public User CreateUser(int age, string name, DateTime birthDate)
        {
            throw new NotImplementedException();
        }

        public void DeleteAward(Award award)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public void EditAge(int newAge)
        {
            throw new NotImplementedException();
        }

        public void EditDateOfBirth(DateTime newBirthDate)
        {
            throw new NotImplementedException();
        }

        public void EditName(string newName)
        {
            throw new NotImplementedException();
        }

        public void EditTitle(string newTitle)
        {
            throw new NotImplementedException();
        }

        public Award GetAward(Award award)
        {
            throw new NotImplementedException();
        }

        public User GetUser()
        {
            throw new NotImplementedException();
        }
    }
}