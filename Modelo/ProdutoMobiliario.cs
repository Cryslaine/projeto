using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProdutoMobiliario : ModProduto
    {
        public ProdutoMobiliario() : base()
        {

        }
        public ProdutoMobiliario(double valorProduto) : base(valorProduto)
        {

        }

        public new int Id { get; set; }
        public decimal Altuta { get; set; }
        public decimal Comprimento { get; set; }
        public new decimal Tamanho { get; set; }

        public override double CalcularImposto(double valorProduto)
        {
            return valorProduto * 0.15;
        }

    }   
}
