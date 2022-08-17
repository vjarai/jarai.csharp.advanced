using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jarai.RestApi.EntityModel
{
    [Table("Order Details")]
    public class Order_Detail
    {
        public float Discount { get; set; }

        public virtual Order Order { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        public virtual Product Product { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        public short Quantity { get; set; }

        [Column(TypeName = "money")] public decimal UnitPrice { get; set; }
    }
}