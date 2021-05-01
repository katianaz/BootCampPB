using SolucaoBaseBootCamp.WebApi.Model;
using System.Collections.Generic;

namespace ArquivoBaseBootcamp.Services
{
    public interface IInteresseService
    {
        public InteresseModel Consultar(string email);
        public List<InteresseModel> ConsultarTodos();
        public bool Incluir(InteresseModel interesse);
        public bool Atualizar(InteresseModel interesse);
        public bool Excluir(string email);
    }
}
