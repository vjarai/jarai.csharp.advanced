using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jarai.CSharp.EF6.CodeFirst
{
    public class Person
    {
        public Person()
        {
            
        }

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string FirstName { get; set; }

        public DateTime Geburtstag { get; set; }

        /// <summary>
        /// Virtual Navigation Properties ermöglichen "Lazy Loading",
        /// d.h. beim ersten Zugriff werden die Daten Nachgeladen (Performance)
        /// </summary>
        public virtual List<Seminar> Seminare { get; set; } = new List<Seminar>();

        public void AddSeminar(Seminar seminar1)
        {
           this.Seminare.Add(seminar1);
           seminar1.Teilnehmer.Add(this);
        }
    }
}