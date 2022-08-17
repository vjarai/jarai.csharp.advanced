using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Jarai.RestApi.EntityModel
{
    public class Product
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Order_Details = new HashSet<Order_Detail>();
        }

        public virtual Category Category { get; set; }

        public int? CategoryID { get; set; }

        public bool Discontinued { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Detail> Order_Details { get; set; }

        public int ProductID { get; set; }

        [Required] [StringLength(40)] public string ProductName { get; set; }

        [StringLength(20)] public string QuantityPerUnit { get; set; }

        public short? ReorderLevel { get; set; }

        public virtual Supplier Supplier { get; set; }

        public int? SupplierID { get; set; }

        [Column(TypeName = "money")] public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public short? UnitsOnOrder { get; set; }
    }
}