namespace VH_Burguer.DTOs.LogProdutoDto
{
    public class LerLogProdutoDto
    {
        public int LogID { get; set; }

        public int? ProdutoID { get; set; }

        public string NomeAnterior { get; set; }

        public decimal? PrecoAnterior { get; set; }

        public DateTime DataAlteracao { get; set; }
    }
}
