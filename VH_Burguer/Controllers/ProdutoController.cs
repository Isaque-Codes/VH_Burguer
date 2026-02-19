using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using VH_Burguer.DTOs.ProdutoDto;
using VH_Burguer.Exceptions;
using VHBurguer.Applications.Services;

namespace VHBurguer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _service;

        public ProdutoController(ProdutoService service)
        {
            _service = service;
        }

        // Autenticação do usuário
        private int ObterUsuarioIdLogado()
        {
            // Busca o ID  do usuário no token
            // ClaimTypes.NameIdentifier geralmente guarda esse ID
            string? idTexto = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrWhiteSpace(idTexto))
            {
                throw new DomainException("Usuário não autenticado.");
            }

            // Converte o ID de string para int
            // Claims sempre armazenam dados como string
            return int.Parse(idTexto);
        }

        [HttpGet]
        public ActionResult<List<LerProdutoDto>> Listar()
        {
            List<LerProdutoDto> produtos = _service.Listar();

            //return StatusCode(200, produtos);
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public ActionResult<LerProdutoDto> ObterPorId(int id)
        {
            LerProdutoDto produto = _service.ObterPorId(id);

            if (produto == null)
            {
                //return StatusCode(404);
                return NotFound();
            }

            return Ok(produto);
        }

        // api/produto/5/imagem
        [HttpGet("{id}/imagem")]
        public ActionResult ObterImagem(int id)
        {
            try
            {
                var imagem = _service.ObterImagem(id);
                // Mostra ao navegador como renderizar a imagem
                return File(imagem, "image/jpeg");
            }
            catch (DomainException ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}