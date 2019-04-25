using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAdo02
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new Group()
            {
                Name = "Sapar"
            };

            using (var context = new AppContext())
            {
                context.Group.Add(group);
            }
        }
    }
}
