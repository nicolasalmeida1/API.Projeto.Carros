namespace Projeto.Avanade.Domain
{
    /// <summary>
    /// Classe de Carro
    /// </summary>
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public bool Novo { get; set; }

    }
}


//TODO: Alterar para SET Privado
//TODO: Utilizar Construtor