using BibliotecaWebApi.Models;
using BibliotecaWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly ILivrosService _livrosService;

        public LivrosController(ILivrosService livrosService)
        {
            _livrosService = livrosService;
        }

        [HttpGet]
        public async Task<IActionResult> GetLivros()
        {
            return Ok(await _livrosService.GetLivros());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLivroById(int id)
        {
            return Ok(await _livrosService.GetLivroById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddLivro(LivroModel novoLivro)
        {
            return Ok(await _livrosService.AddLivro(novoLivro));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateLivro(LivroModel alteradoLivro)
        {
            return Ok(await _livrosService.UpdateLivro(alteradoLivro));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteLivro(int id)
        {
            return Ok(await _livrosService.DeleteLivro(id));
        }
    }
}
