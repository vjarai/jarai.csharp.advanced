using System.Linq;

namespace Jarai.CSharp.Ef6.DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var db = new Database())
            {
                var personen = db.Person.ToList();
            }
        }
    }
}
