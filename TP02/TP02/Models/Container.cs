using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Diagnostics.CodeAnalysis;

namespace TP02.Models
{
    [Table("Container")]
    public class Container
    {
        [Key]
        [DisallowNull]
        [Display(Name = "Número")]
        [Column("Numero")]
        public int Numero { get; set; }

        [DisallowNull]
        [Display(Name = "Tipo")]
        [Column("Tipo")]
        public string Tipo { get; set; }

        [DisallowNull]
        [Display(Name = "Tamanho")]
        [Column("Tamanho")]
        public double Tamanho { get; set; }
    }
}