namespace ListaParaFazer.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Descricao { get; set; }
        public int DiasParaRealizar { get; set; } = 5;
        public DateTime DataInicial { get; set; } = DateTime.Now;
        public DateTime DataFinal { get; set; }
        public bool Realizada {get; set;}

        public TarefaModel(string title, 
            string descricao, 
            int diasParaRealizar, 
            DateTime dataInicial,
            DateTime dataFinal,
            bool realizada)
        {
            Title = title;
            Descricao = descricao;
            DiasParaRealizar = diasParaRealizar;
            DataInicial = dataInicial;
            DataFinal = DataFinal.AddDays(diasParaRealizar);
            Realizada = realizada;
        }
    }
}
