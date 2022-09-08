using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef6.DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var db = new Model1())
            {
                var personen = db.People.ToList();
            }
        }
    }
}
