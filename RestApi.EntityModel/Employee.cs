using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Jarai.RestApi.EntityModel
{
    public class Employee
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Employees1 = new HashSet<Employee>();
            Orders = new HashSet<Order>();
            Territories = new HashSet<Territory>();
        }

        [StringLength(60)] public string Address { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(15)] public string City { get; set; }

        [StringLength(15)] public string Country { get; set; }

        public virtual Employee Employee1 { get; set; }

        public int EmployeeID { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees1 { get; set; }

        [StringLength(4)] public string Extension { get; set; }

        [Required] [StringLength(10)] public string FirstName { get; set; }

        public DateTime? HireDate { get; set; }

        [StringLength(24)] public string HomePhone { get; set; }

        [Required] [StringLength(20)] public string LastName { get; set; }

        [Column(TypeName = "ntext")] public string Notes { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [Column(TypeName = "image")] public byte[] Photo { get; set; }

        [StringLength(255)] public string PhotoPath { get; set; }

        [StringLength(10)] public string PostalCode { get; set; }

        [StringLength(15)] public string Region { get; set; }

        public int? ReportsTo { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Territory> Territories { get; set; }

        [StringLength(30)] public string Title { get; set; }

        [StringLength(25)] public string TitleOfCourtesy { get; set; }
    }
}