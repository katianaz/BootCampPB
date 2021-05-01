using SolucaoBaseBootCamp.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArquivoBaseBootcamp.Services
{
    public class InteresseService : IInteresseService
    {
        private List<InteresseModel> _listaInteresse { get; set; }

        public InteresseService()
        {
            _listaInteresse = new List<InteresseModel>();
        }

        public bool Atualizar(InteresseModel interesse)
        {
            var indice = _listaInteresse.FindIndex(x => x.Email == interesse.Email);
            if (indice != -1)
            {
                _listaInteresse[indice] = interesse;
                return true;
            }

            return false;
        }

        public InteresseModel Consultar(string email)
        {
            return _listaInteresse.FirstOrDefault(x => x.Email == email);
        }

        public List<InteresseModel> ConsultarTodos()
        {
            return _listaInteresse;
        }

        public bool Excluir(string email)
        {
            var resultado = _listaInteresse.FirstOrDefault(x => x.Email == email);
            if (resultado != null)
            {
                _listaInteresse.Remove(resultado);
                return true;
            }

            return false;
        }

        public bool Incluir(InteresseModel interesse)
        {
            var resultado = _listaInteresse.FirstOrDefault(x => x.Email == interesse.Email);
            if (resultado == null)
            {
                _listaInteresse.Add(interesse);
                return true;
            }

            return false;
        }

    }
}
