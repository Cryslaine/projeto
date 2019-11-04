using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    public class ModNotaFiscal 
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Numero é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Numero da Nota")]
        [StringLength(10,MinimumLength=1)]
        [RegularExpression(@"^[\d,{9}]+$", ErrorMessage = 
            "Letras e caracteres especiais não são permitidos no numero.")]
        public string Numero {  get; set; }

        
        [Required(ErrorMessage = "O Produto é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Produto")]
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "O Valor é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Valor do produto")]
        [RegularExpression(@"^[\d,{9}\,,\.)]+$")]
        [DisplayFormat(DataFormatString = "{0,c}")]
        public double Valor { get; set; }


        [Required(ErrorMessage = "Razão Social é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Razão Social")]
        public int RazaoSocial { get; set; }
       

    }
}
