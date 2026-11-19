public class Palavra
{
    private string _texto;
    private bool _estaOculta = false;

    public Palavra(string texto)
    {
        _texto = texto;
    }

    public void Ocultar()
    {
        _estaOculta = true;
    }

    public void Exibir()
    {
        _estaOculta = false;
    }

    public bool EstaOculta()
    {
        return _estaOculta;
    }

    public string ObterTexto()
    {
        string texto = new string('_', _texto.Length);

        if (_estaOculta)
        {
            return texto;
        }

        return _texto;
    }
}
