using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModItemNotaFiscal 
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Produto é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Produto")]

        public int IdProduto { get; set; }
     
        public ModProduto Produto { get; set; }

        [Required(ErrorMessage = "Quantidade é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Quantidade")]
        [RegularExpression(@"^[\d,{9})]+$")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "O Valor é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Valor do produto")]
        [RegularExpression(@"^[\d,{9}\,,\.)]+$")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###,##0.00}")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "O Id Nota Fiscal é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Id Nota Fisca")]
        public int IdNotaFiscal { get; set; }
        public ModNotaFiscal NotaFiscal { get; set; }

        public bool ValorProduto { get; set; }

    }
}
