using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public sealed class TipoTelefone
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tipo  deve ser informado!", AllowEmptyStrings = false)]
        public string Descricao { get; set; }
    }
}
