using System.ComponentModel.DataAnnotations;

namespace Projeto.Avanade.Domain
{
    /// <summary>
    /// Classe de Carro
    /// </summary>
    public class Carro
    {
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        [Range(1990, 2023, ErrorMessage = "Por favor, insira um ano entre 1990 e 2023")]
        public int Ano { get; set; }
        [Required]
        public bool Novo { get; set; }

    }
}


//TODO: Alterar para SET Privado
//TODO: Utilizar Construtor