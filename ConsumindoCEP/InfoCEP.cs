namespace ConsumindoCEP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InfoCEP")]
    public partial class InfoCEP
    {
        [StringLength(255)]
        public string Endereco { get; set; }

        [StringLength(255)]
        public string Bairro { get; set; }

        [StringLength(255)]
        public string Cidade { get; set; }

        [StringLength(255)]
        public string UF { get; set; }

        [StringLength(255)]
        public string Cep { get; set; }

        [Key]
        public int CepId { get; set; }
    }
}
