using Task8.BLL.Interfaces;
using Task8.Entities;
using Task8.DAL.Json;
using Task8.DAL.Json.Interfaces;

namespace Task8.BL
{
    public class Logic : IBLL
    {
        private IUser _user;
        private IAward _award;

        public Logic(IUser user, IAward award)
        {
            _user = user;
            _award = award;
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