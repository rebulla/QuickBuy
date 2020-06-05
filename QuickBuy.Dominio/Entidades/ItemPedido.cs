namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0) AdicionarCritica("Não foi possível identificar o produto desejado.");
            if (Quantidade == 0) AdicionarCritica("Quantidade deve ser informada.");
        }
    }
}
