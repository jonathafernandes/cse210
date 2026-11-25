using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Introdução à Programação com Classes",
            "Canal CSE 210",
            420
        );
        video1.AdicionarComentario(new Comentario("Ana", "Explicação muito clara!"));
        video1.AdicionarComentario(new Comentario("Bruno", "Este exemplo me ajudou bastante."));
        video1.AdicionarComentario(new Comentario("Carla", "Agora entendi abstração."));
        videos.Add(video1);

        Video video2 = new Video(
            "Encapsulamento em C#",
            "Código Simples",
            365
        );
        video2.AdicionarComentario(new Comentario("Daniel", "Gostei dos exemplos."));
        videos.Add(video2);

        Video video3 = new Video(
            "Trabalhando com Listas",
            "Aprenda C#",
            510
        );
        video3.AdicionarComentario(new Comentario("Gabriela", "Finalmente entendi listas!"));
        video3.AdicionarComentario(new Comentario("Henrique", "A explicação foi muito útil."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.ExibirDetalhes();
        }
    }
}
