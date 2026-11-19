public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] palavras = texto.Split(' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string palavra in palavras)
        {
            _palavras.Add(new Palavra(palavra));
        }
    }

    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        List<Palavra> palavrasVisiveis = new List<Palavra>();

        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                palavrasVisiveis.Add(palavra);
            }
        }

        int quantidade = Math.Min(numeroParaOcultar, palavrasVisiveis.Count);

        for (int i = 0; i < quantidade; i++)
        {
            int indice = Random.Shared.Next(palavrasVisiveis.Count);
            Palavra palavraSorteada = palavrasVisiveis[indice];
            palavraSorteada.Ocultar();

            palavrasVisiveis.RemoveAt(indice);
        }
    }

    public string ObterTexto()
    {
        string textoCompleto = _referencia.ObterTexto();

        foreach (Palavra palavra in _palavras)
        {
            textoCompleto += " " + palavra.ObterTexto();
        }

        return textoCompleto;
    }

    public bool EstaCompletamenteOculta()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                return false;
            }
        }
        return true;
    }
}
