using System.Collections.Generic;

namespace Jarai.CSharp.EF6.CodeFirst
{
    public class Seminar
    {
        public Seminar()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public virtual List<Person> Teilnehmer { get; set; } = new List<Person>();
    }
}