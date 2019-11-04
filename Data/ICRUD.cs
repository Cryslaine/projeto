using System.Collections.Generic;

namespace Modelo
{
    public interface ICRUD <t>
    {
        /*
         * aqui vams fazer assinaturas dos métodos padrões
         * para interação com o banco de dados
         * utilizaremos com parâmetro um tipo genérico .(nível intermediario)
         */
        void Adicionar(t entidade);
        void Atualizar(t entidade);
        void Deletar(int id);

        List<t> SelecionarTodos();
        t SelecionarPorId(int id);

    }
}
