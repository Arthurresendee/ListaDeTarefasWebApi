namespace ListaParaFazer.Models.ViewModels.Tarefa
{
    public class UpdateTarefaViewModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Descricao { get; set; }
        public int? DiasParaRealizar { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool? Realizada { get; set; }
    }
}
