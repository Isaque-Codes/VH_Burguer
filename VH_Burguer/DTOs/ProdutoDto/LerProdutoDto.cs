using VH_Burguer.Domains;

namespace VH_Burguer.DTOs.ProdutoDto
{
    public class LerProdutoDto
    {
        public int ProdutoID { get; set; }

        public string Nome { get; set; } = null!;

        public decimal Preco { get; set; }

        public string Descricao { get; set; } = null!;

        public byte[] Imagem { get; set; } = null!;

        public bool? StatusProduto { get; set; }

        // CATEGORIAS
        public List<int> CategoriaIds { get; set; } = new();

        public List<string> Categorias { get; set; } = new();


        // USUÁRIO QUE CADASTROU
        public int? UsuarioID { get; set; }

        public string? UsuarioNome { get; set; }

        public string? UsuarioEmail { get; set; }

        public virtual ICollection<Log_AlteracaoProduto> Log_AlteracaoProduto { get; set; } = new List<Log_AlteracaoProduto>();

        public virtual ICollection<ProdutoPromocao> ProdutoPromocao { get; set; } = new List<ProdutoPromocao>();

        public virtual Usuario? Usuario { get; set; }

        public virtual ICollection<Categoria> Categoria { get; set; } = new List<Categoria>();
    }
}
