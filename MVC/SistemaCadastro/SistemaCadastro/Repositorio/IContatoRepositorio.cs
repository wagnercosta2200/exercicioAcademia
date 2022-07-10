using SistemaCadastro.Models;

namespace SistemaCadastro.Repositorio
{   //Metodo recebe o contato e adicona o contato no banco
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
