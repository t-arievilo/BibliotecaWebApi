using BibliotecaWebApi.Models;

namespace BibliotecaWebApi.Services;

public interface ILivrosService
{
    Task<ServiceResponse<List<LivroModel>>> GetLivros();
    Task<ServiceResponse<LivroModel>> GetLivroById(int id);
    Task<ServiceResponse<List<LivroModel>>> AddLivro(LivroModel novoLivro);
    Task<ServiceResponse<List<LivroModel>>>UpdateLivro(LivroModel alteradolivro);
    Task<ServiceResponse<List<LivroModel>>> DeleteLivro(int id);
}