public class Banda {
    private List<Album> albums = new List<Album>();

    //ctor 
    public Banda(string nome) {
        Nome = nome;
    }
    public string Nome { get; }
    public void AdicionarAlbum(Album album) {
        albums.Add(album);
    }
    public void ExibirDiscografia() {
        Console.WriteLine($"Discogradia da banda {Nome}");
         foreach (Album album in albums) {
            Console.WriteLine($"Álbum: {album.Nome}");
            Console.WriteLine($"Duração total: {album.DuracaoTotal}");
        }
    }
}