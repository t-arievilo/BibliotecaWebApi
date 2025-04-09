using System.ComponentModel.DataAnnotations;
using BibliotecaWebApi.Enums;

namespace BibliotecaWebApi.Models
{
    public class LivroModel
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public Genero Genero { get; set; }
        public bool Disponivel { get; set; }
    }
}
