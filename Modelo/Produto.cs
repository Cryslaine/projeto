using System;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    // emcapsulamento
    public class ModProduto
    {
        // su crysmmary

        [Key]
        public int Id { get; set; }

        public ModFornecedor FornMOD { get; set; }

        [Required(ErrorMessage = "Fornecedor deve ser informado!" , AllowEmptyStrings = false)]
        public int IdFornecedor { get; set; }


        [Required(ErrorMessage = "Produto deve ser informado!" , AllowEmptyStrings = false)]
        public string Pro_Nome { get; set; }


        [Required(ErrorMessage = "Preço deve ser informado!" , AllowEmptyStrings = false)]
        [Display(Name = "Preco do Produto")]
        [RegularExpression(@"^[\d,{9}\,,\.)]+$")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###,##0.00}")]
        public double Preco { get; set; }


        [Required(ErrorMessage = "Tamanho deve ser informado!", AllowEmptyStrings = false)]
        
        public int Tamanho { get; set; }


        [Required(ErrorMessage = "Peso deve ser informado!")]
        [RegularExpression(@"^[\d,{9},\.)]+$")]
        public decimal Peso { get; set; }


        [Required(ErrorMessage = "Cor deve ser informado!" , AllowEmptyStrings = false)]
       
        public string Cor { get; set; }


        [Required(ErrorMessage = "Quantidade deve ser informada!", AllowEmptyStrings = false)]
        public int Quantidade { get; set; }



        public readonly double PrecoVenda;

      
        public ModProduto(double valorProduto = 0) // metodo contrutor
        {
            if(valorProduto != 0)
                this.PrecoVenda = valorProduto + (valorProduto * 0.20); // this->este
          
        }
        public virtual double CalcularImposto(double valorProduto)
        {
            return valorProduto * 0.10; // metodos -> instruçoes
            
        }
    }
}
