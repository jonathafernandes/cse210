public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;
    private const double FreteEua = 5.00;
    private const double FreteInternacional = 35.00;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public double CalcularPrecoTotal()
    {
        double total = 0;

        foreach (Produto produto in _produtos)
        {
            total += produto.CalcularCustoTotal();
        }

        if (_cliente.MoraNosEUA())
        {
            total += FreteEua;
        }
        else
        {
            total += FreteInternacional;
        }

        return total;
    }

    public string GerarEtiquetaEmbalagem()
    {
        List<string> linhas = new List<string>();
        foreach (Produto produto in _produtos)
        {
            linhas.Add(produto.ObterLinhaEtiqueta());
        }

        return string.Join("\n", linhas);
    }

    public string GerarEtiquetaEnvio()
    {
        return _cliente.ObterEtiquetaEnvio();
    }
}
