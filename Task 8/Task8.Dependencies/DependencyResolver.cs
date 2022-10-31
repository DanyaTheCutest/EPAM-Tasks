using Task8.DAL.Json.Interfaces;
using Task8.DAL.Json;
using Task8.BLL.Interfaces;
using Task8.BL;

namespace Task8.Dependencies
{
    public class DependencyResolver
    {
        private static DependencyResolver _instance;
        public static DependencyResolver Instance => _instance ??= new DependencyResolver();
        private DependencyResolver()
        {

        }

        public IUser User => new DALJson();

        public IAward Award => new DALJson();

        public IBLL BLL => new Logic(User, Award);
    }
}