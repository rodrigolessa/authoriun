namespace AuthoriunApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Core.RequerenteCliente")]
    public partial class RequerenteCliente
    {
        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdRequerente { get; set; }

        public int IdCliente { get; set; }

        public int CriadoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CriadoEm { get; set; }

        public int? AlteradoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AlteradoEm { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Requerente Requerente { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
