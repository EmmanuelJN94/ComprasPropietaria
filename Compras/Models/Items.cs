namespace Compras.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Items
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Items()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal item_id { get; set; }

        [StringLength(50)]
        public string item_desc { get; set; }

        [StringLength(50)]
        public string brand { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? unit_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? item_amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        public bool? item_status { get; set; }

        public virtual Measurement_units Measurement_units { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
