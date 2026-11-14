public class Diario
{
    public List<Registro> _registros = new List<Registro>();
    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }
    public void ExibirTodos()
    {
        foreach (Registro r in _registros)
        {
            r.Exibir();
        }

    }
    public void SalvarNoArquivo(string arquivo)
    {
        using (StreamWriter saida = new StreamWriter(arquivo))
        {
            foreach (Registro r in _registros)
            {
                saida.WriteLine($"{r._data}~|~{r._textoPergunta}~|~{r._textoResposta}");
            }
        }
    }
    public void CarregarDoArquivo(string arquivo)
    {
        if (!System.IO.File.Exists(arquivo))
        {
            Console.WriteLine("O arquivo não existe!");
            Console.WriteLine("");
            return;
        }

        List<Registro> registrosCarregados = new List<Registro>();

        foreach (string linha in System.IO.File.ReadAllLines(arquivo))
        {
            string[] partes = linha.Split("~|~");

            Registro registro = new Registro();
            registro._data = partes[0];
            registro._textoPergunta = partes[1];
            registro._textoResposta = partes[2];

            registrosCarregados.Add(registro);
        }

        _registros = registrosCarregados;
    }
}