using BibliotecaWebApi.DataContext;
using BibliotecaWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaWebApi.Services
{
    public class LivrosService : ILivrosService
    {
        private readonly ApplicationDbContext _context;
        public LivrosService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<LivroModel>>> GetLivros()
        {
            ServiceResponse<List<LivroModel>> serviceResponse = new ServiceResponse<List<LivroModel>>();

            try
            {
                serviceResponse.Dados = await _context.Livros.ToListAsync();
                if (serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Mensagem = "Nenhum livro encontrado.";
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }
        public async Task<ServiceResponse<LivroModel>> GetLivroById(int id)
        {
            ServiceResponse<LivroModel> serviceResponse = new ServiceResponse<LivroModel>();
            try
            {
                serviceResponse.Dados = await _context.Livros.FirstOrDefaultAsync(p => p.Id == id);
                if (serviceResponse.Dados == null)
                {
                    serviceResponse.Mensagem = "Nenhum livro encontrado.";
                }
            }
            catch(Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<LivroModel>>> AddLivro(LivroModel novoLivro)
        {
            ServiceResponse<List<LivroModel>> serviceResponse = new ServiceResponse<List<LivroModel>>();

            try
            {
                if (novoLivro == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Insira as informações.";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;
                }

                _context.Add(novoLivro);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = await _context.Livros.ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<LivroModel>>> UpdateLivro(LivroModel alteradolivro)
        {
            ServiceResponse<List<LivroModel>> serviceResponse = new ServiceResponse<List<LivroModel>>();

            try
            {
                if (alteradolivro == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Insira as informações.";
                    serviceResponse.Sucesso = false;
                }

                _context.Update(alteradolivro);
                _context.SaveChangesAsync();

                serviceResponse.Dados = _context.Livros.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<LivroModel>>> DeleteLivro(int id)
        {
            ServiceResponse<List<LivroModel>> serviceResponse = new ServiceResponse<List<LivroModel>>();
            try
            {
              LivroModel livro = await _context.Livros.FirstOrDefaultAsync(p => p.Id == id);

              if (livro == null)
              
              {
                      serviceResponse.Sucesso = false;
                      serviceResponse.Mensagem = "Livro não encontrado.";
                      return serviceResponse;
              }
                
              _context.Remove(livro);
              await _context.SaveChangesAsync();

              serviceResponse.Dados = await _context.Livros.ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }
    }
}

    
