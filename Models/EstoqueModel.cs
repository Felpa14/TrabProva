using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrabProva.Models
{
    [Table("tb_estoque")]
    public class EstoqueModel
    {
        [Display(Name="Codigo")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Vendedor")]
        [Column("Vendedor")]
        public string Vendedor { get; set; }

        [Display(Name = "Cliente")]
        [Column("Cliente")]
        public string Cliente { get; set; }

        [Display(Name = "Produto")]
        [Column("Produto")]
        public string Produto { get; set; }

        [Display(Name = "Marca")]
        [Column("Marca")]
        public string Marca { get; set; }

    }
}
