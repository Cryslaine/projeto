
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class ModEmpresa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Razão Social deve ser informado!", AllowEmptyStrings = false)]
        public string NomeRazaoSocial { get; set; }

        [Required(ErrorMessage = "Nome Fantasia deve ser informado!", AllowEmptyStrings = false)]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Cnpj deve ser informado!", AllowEmptyStrings = false)]
        [RegularExpression(@"^[\d,{9}\-,\(,\),\.)]+$")]
        [StringLength(18, MinimumLength = 14)]
        public string Cnpj { get; set; }


        [Required(ErrorMessage = "Endereço deve ser informado!", AllowEmptyStrings = false)]
        public string Endereco { get; set; }


        [Required(ErrorMessage = "Bairro deve ser informado!", AllowEmptyStrings = false)]
        public string Bairro { get; set; }


        [Required(ErrorMessage = "Cidade deve ser informado!", AllowEmptyStrings = false)]
        public string Cidade { get; set; }


        [Required(ErrorMessage = "Número deve ser informado!", AllowEmptyStrings = false)]
        public string Numero { get; set; }


        [Required(ErrorMessage = "Uf deve ser informado!", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string UF { get; set; }


        [Required(ErrorMessage = "Cep deve ser informado!", AllowEmptyStrings = false)]
        [RegularExpression(@"^[\d,{9},\-)]+$")]
        [StringLength(9, MinimumLength = 9)]
        public string CEP { get; set; }


        [Required(ErrorMessage = "Complemento deve ser informado!", AllowEmptyStrings = false)]
        [StringLength(20, MinimumLength = 2)]
        public string Complemento { get; set; }

    }

}


