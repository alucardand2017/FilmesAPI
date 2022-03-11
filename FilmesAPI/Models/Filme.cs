using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo título é obrigatório!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage ="Defina o nome do Diretor!")]
        [StringLength(50, ErrorMessage = "Tamanho máximo no campo diretor ultrapassado")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage ="Valor máximo ultrapassado!")]
        public string Genero { get; set; }
        [Required]
        [Range(10,800, ErrorMessage ="Tamanho máximo do campo duração foi excedido!"),]
        public int Duracao { get; set; }
    }
}
