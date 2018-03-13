namespace Compras.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal order_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? order_date { get; set; }

        public bool? order_status { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? item_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? order_amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? supplier_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dept_id { get; set; }

        public virtual Departments Departments { get; set; }

        public virtual Items Items { get; set; }

        public virtual Suppliers Suppliers { get; set; }
    }
}
