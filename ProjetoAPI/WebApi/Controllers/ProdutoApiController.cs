using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoAPI.Entidades;
using ProjetoAPI.Interfaces;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Authorize]
    public class ProdutoApiController : Controller
    {
        private readonly IProduto Iproduto;

        public ProdutoApiController(IProduto IProduto)
        {
            this.Iproduto = IProduto;
        }

        [HttpGet("/api/ListaProdutos")]
        public async Task<JsonResult> ListaProdutos()
        {
            return Json(await this.Iproduto.List());
        }

        [HttpPost("/api/AdicionarProduto")]
        public async Task AdicionarProduto([FromBody] Produto produto)
        {
            await Task.FromResult(this.Iproduto.Add(produto));
        }
    }
}