namespace ReplacementExcel.Models
{
    public class ReposicaoEstoque
    {
        public string Codigo { get; set; }
        public string Medicamento { get; set; }
        public string Unidade { get; set; }
        public DateTime UltimoMovimento { get; set; }
        public float ConsumoTotal { get; set; }
        public float EstoqueAtual { get; set; }
        public int DiasDeEstoque { get; set; }
    }
}
