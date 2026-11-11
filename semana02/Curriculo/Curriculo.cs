public class Curriculo
{
    public string _nomePessoa;
    public List<Emprego> _empregos = new List<Emprego>();
    public void ExibirDetalhesCurriculo()
    {
        Console.WriteLine($"Nome: {_nomePessoa}");
        Console.WriteLine("Empregos:");

        foreach (Emprego e in _empregos)
        {
            e.ExibirDetalhesEmprego();
        }
    }
}