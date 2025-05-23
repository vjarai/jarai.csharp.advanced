using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Jarai.RestApi.EntityModel
{
    public class Order
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Order_Details = new HashSet<Order_Detail>();
        }

        public virtual Customer Customer { get; set; }

        [StringLength(5)] public string CustomerID { get; set; }

        public virtual Employee Employee { get; set; }

        public int? EmployeeID { get; set; }

        [Column(TypeName = "money")] public decimal? Freight { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Detail> Order_Details { get; set; }

        public DateTime? OrderDate { get; set; }

        public int OrderID { get; set; }

        public DateTime? RequiredDate { get; set; }

        [StringLength(60)] public string ShipAddress { get; set; }

        [StringLength(15)] public string ShipCity { get; set; }

        [StringLength(15)] public string ShipCountry { get; set; }

        [StringLength(40)] public string ShipName { get; set; }

        public DateTime? ShippedDate { get; set; }

        public virtual Shipper Shipper { get; set; }

        [StringLength(10)] public string ShipPostalCode { get; set; }

        [StringLength(15)] public string ShipRegion { get; set; }

        public int? ShipVia { get; set; }
    }
}