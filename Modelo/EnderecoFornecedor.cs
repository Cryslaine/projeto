using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class ModEnderecoFornecedor 
    {

        [Key]
        public int Id { get; set; }

        public ModFornecedor FornecedorMod { get; set; }

        [Required(ErrorMessage = "Fornecedor deve ser informado!", AllowEmptyStrings = false)]
        public int IdFornecedor { get; set; }


        [Required(ErrorMessage = "Endereço deve ser informado!", AllowEmptyStrings = false)]
        public string Endereco { get; set; }


        [Required(ErrorMessage = "Bairro deve ser informado!", AllowEmptyStrings = false)]
        public string Bairro { get; set; }


        [Required(ErrorMessage = "Número deve ser informado!", AllowEmptyStrings = false)]
        public string Numero { get; set; }


        [Required(ErrorMessage = "Cidade deve ser informado!", AllowEmptyStrings = false)]
        
        public string Cidade { get; set; }


        [Required(ErrorMessage = "Cep deve ser informado!", AllowEmptyStrings = false)]
        [StringLength(9, MinimumLength = 9)]
        public string CEP { get; set; }


        [Required(ErrorMessage = "Uf deve ser informado!", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        [StringLength(2, MinimumLength = 2)]
        public string UF { get; set; }


        [Required(ErrorMessage = "Complemento deve ser informado!", AllowEmptyStrings = false)]
        [StringLength(20, MinimumLength = 2)]
        public string Complemento { get; set; }
        public bool BotaoEndereco { get; set; }

    }
}
