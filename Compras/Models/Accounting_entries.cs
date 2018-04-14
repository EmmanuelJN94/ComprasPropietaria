namespace Compras.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Accounting_entries
    {
        [Key]
        public int AsientoContableId { get; set; }

        public int AuxiliarId { get; set; }

        public DateTime AsientoContableFecha { get; set; }

        [StringLength(200)]
        public string AsientoContableDescripcion { get; set; }

        public int AsientoContableCuentaDebito { get; set; }

        public int AsientoContableCuentaCredito { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AsientoContableMonto { get; set; }

        public int? AsientoContableEstado { get; set; }

        public int? AsientoContableExternoId { get; set; }
    }
}
