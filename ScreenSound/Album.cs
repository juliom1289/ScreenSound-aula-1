public class Album {
    private List<Musica> musicas = new List<Musica>();
    public Album(string nome) {//esse formato serve para enxutar o código e dificultar o acesso a Nome (Construtor)
        Nome = nome; 
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao); //método lamda, somar Duração de todas as musicas
    public void AdicionarMusica(Musica/*classe música do tipo = */ musica) {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum() {
        Console.WriteLine($"\nLista de músicas do álbum {Nome}, duração {DuracaoTotal}:\n");
        foreach (var musica in musicas) {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        
    }
}