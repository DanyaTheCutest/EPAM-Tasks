using Task8.DALJson.Interfaces;
using Task8.DALJson;

namespace Task8.Dependencies
{
    public class DependencyResolver
    {
        private DependencyResolver _instance;
        public DependencyResolver Instance => _instance ??= new DependencyResolver();
        private DependencyResolver()
        {

        }

        private IUser _user => new DALJson();

    }
}