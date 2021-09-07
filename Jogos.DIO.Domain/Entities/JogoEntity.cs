namespace Jogos.DIO.Domain.Entities
{
    public class JogoEntity : BaseEntity
    {
        public string NmJogo { get; set; }
        public string NmProdutora { get; set; }
        public decimal Preco { get; set; }
    }
}
