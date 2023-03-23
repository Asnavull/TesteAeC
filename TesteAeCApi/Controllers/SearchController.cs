using Microsoft.AspNetCore.Mvc;
using TesteAeC.Business.Interface;
using TesteAeC.Model.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteAeCApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IPesquisaAeC _pesquisaAeC;

        public SearchController(IPesquisaAeC pesquisaAeC)
        {
            _pesquisaAeC = pesquisaAeC;
        }

        // GET api/<SearchController>/5
        [HttpGet("{pesquisa}")]
        [ProducesResponseType(typeof(RetornoPesquisa), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public RetornoPesquisa Get(string pesquisa)
        {
            return _pesquisaAeC.Pesquisar(pesquisa);
        }
    }
}