namespace ListaParaFazer.Models.Entities
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Descricao { get; set; }
        public int? DiasParaRealizar { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool? Realizada { get; set; }

        //public TarefaModel() { }

        //public TarefaModel(
        //    string title,
        //    string descricao,
        //    int diasParaRealizar,
        //    DateTime dataInicial,
        //    DateTime dataFinal,
        //    bool realizada)
        //{
        //    Title = title;
        //    Descricao = descricao;
        //    DiasParaRealizar = diasParaRealizar;
        //    DataInicial = dataInicial;
        //    DataFinal = dataFinal;
        //    Realizada = realizada;
        //}

    }
}
