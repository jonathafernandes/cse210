public class Video
{
    private string _titulo;
    private string _autor;
    private int _duracaoSegundos;
    private List<Comentario> _comentarios;
    public Video(string titulo, string autor, int duracaoSegundos)
    {
        _titulo = titulo;
        _autor = autor;
        _duracaoSegundos = duracaoSegundos;
        _comentarios = new List<Comentario>();
    }

    public int ObterQuantidadeComentarios()
    {
        return _comentarios.Count;
    }

    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Título: {_titulo}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Duração: {_duracaoSegundos} segundos");
        foreach (Comentario comentario in _comentarios)
        {
            comentario.Exibir();
        }
        Console.WriteLine($"Quantidade de comentários: {ObterQuantidadeComentarios()}");
        Console.WriteLine("--------------------------------------------------");
    }
}
