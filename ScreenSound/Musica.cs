public class Musica {
   //{ get; set; } -> define a variavel (PROPRIEDADE)
   //métodos para definir leitura(get) e escrita(set) de forma a permitir atribuições aquele que (get e set)


   //atalho prop:

   public Musica(Banda artista, string nome) {//Tipo Construtor 
        Artista = artista;
        Nome = nome;
   }
   public string Nome { get; set; } = string.Empty;
   public Banda Artista { get; } //Musica só aceite o tipo Banda 
   public int Duracao { get; set; } = 0; 
   public bool Disponivel { get; set; }
   public string DescricaoResumida {
               get
       {
           return $"A música {Nome} pertence ao(à) {Artista}";//set é o return e get a leitura de Nome e Artista
       }
          
   }


   /*(só get/leitura) -> public string DescricaoResumida => $"A música {Nome} pertence ào(à) {Artista}"
   particularmente úteis ao trabalhar com coleções de dados,
   operações em sequências de elementos ou ao lidar com delegados.
   */
   public void ExibirFichaTecnica() {
       Console.WriteLine($"Nome: {Nome}");
       Console.WriteLine($"Artista: {Artista.Nome}");
       Console.WriteLine($"Duração: {Duracao}");
       Console.WriteLine(DescricaoResumida);


       if (Disponivel) {
           Console.WriteLine("Disponível no plano.");
       } else {
           Console.WriteLine("Adquira o plano Plus+.");


       }


   }
}
