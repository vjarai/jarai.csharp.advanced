namespace Ef6.DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            Seminars = new HashSet<Seminar>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string FirstName { get; set; }

        public DateTime Geburtstag { get; set; }

        public int? Semester { get; set; }

        [Required]
        [StringLength(128)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seminar> Seminars { get; set; }
    }
}
