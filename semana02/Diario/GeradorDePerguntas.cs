public class GeradorDePerguntas
{
    public List<string> _perguntas = new List<string>
    {
        "Qual foi o maior desafio que você enfrentou esta semana?",
        "O que você aprendeu de importante no dia de hoje?",
        "Qual atividade você mais gostou de realizar e por quê?",
        "Que objetivo você pretende alcançar no próximo dia?",
        "Como você pode melhorar seu desempenho em estudos ou trabalho?"
    };

    public string ObterPerguntaAleatoria()
    {
        Random aleatorio = new Random();
        int indice = aleatorio.Next(_perguntas.Count);
        return _perguntas[indice];
    }
}