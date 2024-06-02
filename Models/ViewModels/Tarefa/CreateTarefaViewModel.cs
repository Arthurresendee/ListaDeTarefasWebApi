namespace ListaParaFazer.Models.ViewModels.Tarefa
{
    public class CreateTarefaViewModel
    {
        public string? Title { get; set; }
        public string? Descricao { get; set; }
        public int? DiasParaRealizar { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
    }
}
