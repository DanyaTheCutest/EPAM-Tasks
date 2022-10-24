using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task8.Entities;

namespace Task8.DAL.Json.Interfaces
{
    public interface IAward
    {
        Award CreateAward(string title);
        void EditTitle(string newTitle);
        void DeleteAward(Award award);
        Award GetAward(Award award);
    }
}
