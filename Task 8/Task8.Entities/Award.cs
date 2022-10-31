using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8.Entities
{
    public class Award
    {
        public Guid ID { get; }
        public string Title { get; }

        public Award(string title)
        {
            ID = Guid.NewGuid();
            Title = title;
        }
    }
}
