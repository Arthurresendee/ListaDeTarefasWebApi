namespace ListaParaFazer.Models.ViewModels
{
    public class ResultViewModel<T>
    {
        public List<T> Data { get; set; } = new();
        public List<string> Errors { get; set; } = new(); //Já inicializando a lista de erros para ela não vir como null qundo não houver erros. Sempre ela será inicializada como vazia.

        public ResultViewModel(T data, List<string> errors)
        {
            Data.Add(data);
            Errors = errors;
        }

        public ResultViewModel(T data)
        {
            Data.Add(data);
        }

        public ResultViewModel(List<string> errors)
        {
            Errors = errors;
        }

        public ResultViewModel(string error)
        {
            Errors.Add(error);
        }
    }
}
