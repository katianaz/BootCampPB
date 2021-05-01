using ArquivoBaseBootcamp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolucaoBaseBootCamp.WebApi.Model;
using System;

namespace ArquivoBaseBootcamp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InteresseController : ControllerBase
    {
        private readonly IInteresseService _interesseService;

        public InteresseController(IInteresseService interesseService)
        {
            _interesseService = interesseService;
        }

        /// <summary>
        /// Este endpoint deve consultar as interessadas cadastradas
        /// </summary>
        /// <returns>
        /// Retorna a lista com todas as interessadas cadastradas
        /// </returns>
        [HttpGet]
        public IActionResult ConsultarTodosInteresses()
        {
            try
            {
                var resultado = _interesseService.ConsultarTodos();
                if (resultado.Count > 0)
                {
                    return Ok(resultado);
                }

                return NotFound("Nenhum usuário encontrado.");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, 
                    "Ocorreu um erro ao consultar, tente novamente ou contate o administrador.");
            }
        }

        /// <summary>
        /// Este endpoint deve consultar a interessada cadastrada
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpGet]
        [Route("consultar/{email}")]
        public IActionResult ConsultarInteresse(string email)
        {
            try
            {
                var resultado = _interesseService.Consultar(email);
                if (resultado != null)
                {
                    return Ok(resultado);
                }

                return NotFound("Nenhum usuário encontrado com este e-mail.");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um erro ao consultar, tente novamente ou contate o administrador.");
            }
        }

        /// <summary>
        ///  Este endpoint deve realizar o inclusao de uma interessada
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpPost]
        [Route("incluir")]
        public IActionResult AdicionarInteresse(InteresseModel interesse)
        {
            try
            {
                if (_interesseService.Incluir(interesse))
                {
                    return Ok("Interesse cadastrado com sucesso.");
                }

                return BadRequest("Já existe um interesse com este e-mail.");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um erro ao adicionar, tente novamente ou contate o administrador.");
            }
        }

        /// <summary>
        /// Este endpoint deve atualizar os dados da interessada cadastrada
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpPut]
        [Route("atualizar")]
        public IActionResult AtualizarInteresse(InteresseModel interesse)
        {
            try
            {
                if (_interesseService.Atualizar(interesse))
                {
                    return Ok("Interesse atualizado com sucesso.");
                }

                return NotFound("Nenhum usuário encontrado com este e-mail.");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um erro ao atualizar, tente novamente ou contate o administrador.");
            }
        }

        /// <summary>
        /// Este endpoint deve excluir a interessada cadastrada
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpDelete]
        [Route("excluir/{email}")]
        public IActionResult ExcluirInteresse(string email)
        {
            try
            {
                if (_interesseService.Excluir(email))
                {
                    return Ok("Interesse excluído com sucesso");
                }

                return NotFound("Nenhum usuário encontrado com este e-mail.");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um erro ao excluir, tente novamente ou contate o administrador.");
            }
        }
    }
}
