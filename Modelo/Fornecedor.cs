using System;
using System.ComponentModel.DataAnnotations;
namespace Modelo
{
    public class ModFornecedor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Fantasia deve ser informado!", AllowEmptyStrings = false)]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Cnpj deve ser informado!", AllowEmptyStrings = false)]
        [StringLength(14, MinimumLength = 14)]
        [RegularExpression(@"^[\d,{9}\-,\(,\),\.)]+$")]
        public string Cnpj { get; set; }


        [Required(ErrorMessage = "Razão Social deve ser informado!", AllowEmptyStrings = false)]
        public string RazaoSocial { get; set; }

     
    }

   

}
