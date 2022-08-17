using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Jarai.RestApi.EntityModel
{
    public class Territory
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Territory()
        {
            Employees = new HashSet<Employee>();
        }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }

        public virtual Region Region { get; set; }

        public int RegionID { get; set; }

        [Required] [StringLength(50)] public string TerritoryDescription { get; set; }

        [StringLength(20)] public string TerritoryID { get; set; }
    }
}