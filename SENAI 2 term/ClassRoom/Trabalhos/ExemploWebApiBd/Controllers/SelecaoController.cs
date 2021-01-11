using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploWebApiBd.Domains;
using ExemploWebApiBd.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExemploWebApiBd.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class SelecaoController : ControllerBase
    {
        SelecaoRepository SelecaoRepository = new SelecaoRepository();

        [HttpGet]
        public IActionResult ListarTodos()
        {
           // return Ok(new { mensagem = "ok" });
            return Ok(SelecaoRepository.Listar());
        }
        /*
        [HttpGet]
        [Route("{id}")]
        public IActionResult ListarPorId(int id)
        {

            return Ok(new { mensagem = id });
            //return Ok(SelecaoRepository.Listar());
        }

        */
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {

            Selecao selecao = SelecaoRepository.BuscarPorId(id);
            if (selecao==null)
            {
                return NotFound();
            }
            return Ok(selecao);
        }


        [HttpPost]
        public IActionResult Cadastrar(Selecao selecao)
        {
            try
            {
                SelecaoRepository.Cadastrar(selecao);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            SelecaoRepository.Deletar(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Atualizar(Selecao selecao)
        {
            try
            {
                Selecao selecaoBuscada = SelecaoRepository.BuscarPorId(selecao.Id);
                if (selecaoBuscada == null)
                    return NotFound();
                SelecaoRepository.Atualizar(selecao);
                return Ok();
                
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
