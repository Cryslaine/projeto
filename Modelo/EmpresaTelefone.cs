using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class ModEmpresaTelefone
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tipo Telefone deve ser informado!", AllowEmptyStrings = false)]
        public TipoTelefone Tipo { get; set; }

        public int IdEmpresa { get; set; }

        [Required(ErrorMessage = " Telefone deve ser informado!", AllowEmptyStrings = false)]
        [DataType (DataType.PhoneNumber)]
        [RegularExpression(@"^[\d,{9}\-,\(,\))]+$")]
        public string Telefone { get; set; }

        public bool VerificaTelEmpresa { get; set; }
    }
}
