using SistemaCadastro.Data;
using SistemaCadastro.Models;

namespace SistemaCadastro.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        //var privada de leitura
        private readonly Contexto _contexto;
        public ContatoRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }
        //pegar todos os dados do banco
        public List<ContatoModel> BuscarTodos()
        {
            return _contexto.Contato.ToList();
        }
        //gravar no banco de dados
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _contexto.Contato.Add(contato);
            _contexto.SaveChanges();

            return contato;
        }

      
    }
}
