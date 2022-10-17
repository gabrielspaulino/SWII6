using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Diagnostics.CodeAnalysis;

namespace TP02.Models
{
    [Table("BL")]
    public class BL
    {
        [Key]
        [DisallowNull]
        [Display(Name = "Número")]
        [Column("Numero")]
        public int Numero { get; set; }

        [DisallowNull]
        [Display(Name = "Consignee")]
        [Column("Consignee")]
        public string Consignee { get; set; }

        [DisallowNull]
        [Display(Name = "Navio")]
        [Column("Navio")]
        public string Navio { get; set; }
    }
}