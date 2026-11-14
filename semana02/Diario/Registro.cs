public class Registro
{
    public string _data;
    public string _textoPergunta;
    public string _textoResposta;
    public void Exibir()
    {
        Console.Write($"Data: {_data}");
        Console.WriteLine($" - {_textoPergunta}");
        Console.WriteLine($"{_textoResposta}");
        Console.WriteLine("");
    }
}