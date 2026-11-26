using System;

class Program
{
    static void Main(string[] args)
    {
        Endereco enderecoEua = new Endereco(
            "123 Center Street",
            "Provo",
            "Utah",
            "EUA"
        );
        Cliente clienteEua = new Cliente("Maria Silva", enderecoEua);
        Pedido pedidoEua = new Pedido(clienteEua);

        pedidoEua.AdicionarProduto(new Produto("Teclado", "TEC-001", 45.00, 1));
        pedidoEua.AdicionarProduto(new Produto("Mouse", "MOU-002", 20.00, 2));

        Endereco enderecoInternacional = new Endereco(
            "Avenida Paulista, 1000",
            "São Paulo",
            "SP",
            "Brasil"
        );
        Cliente clienteInternacional = new Cliente("João Santos", enderecoInternacional);
        Pedido pedidoInternacional = new Pedido(clienteInternacional);

        pedidoInternacional.AdicionarProduto(new Produto("Caderno", "CAD-003", 8.00, 3));
        pedidoInternacional.AdicionarProduto(new Produto("Caneta", "CAN-004", 2.00, 5));

        List<Pedido> pedidos = new List<Pedido>
        {
            pedidoEua,
            pedidoInternacional
        };

        int numeroPedido = 1;

        foreach (Pedido pedido in pedidos)
        {
            Console.WriteLine($"PEDIDO {numeroPedido}");
            Console.WriteLine();
            Console.WriteLine("Etiqueta de embalagem:");
            Console.WriteLine(pedido.GerarEtiquetaEmbalagem());
            Console.WriteLine();
            Console.WriteLine("Etiqueta de envio:");
            Console.WriteLine(pedido.GerarEtiquetaEnvio());
            Console.WriteLine();
            Console.WriteLine($"Preço total: ${pedido.CalcularPrecoTotal():F2}");
            Console.WriteLine("--------------------------------------------------");

            numeroPedido++;
        }
    }
}
