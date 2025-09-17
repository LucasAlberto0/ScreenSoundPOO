Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(1, "Técnicas de aprendizado", 45);
ep1.AdicionarConvidados("Fernando");
ep1.AdicionarConvidados("Marcos");
ep1.AdicionarConvidados("Flavia");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();


// Program.cs
// Banda queen = new Banda("Queen");


// Album albumDoQueen = new Album("A Night at the Opera");
// // albumDoQueen.Nome = "A Night at the Opera";

// Musica musica1 = new Musica(queen, "Love of my life")
// {

//     Duracao = 213,
//     Disponivel = true,
// };

// Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
// {
//     Duracao = 354,
//     Disponivel = false,
// };
// musica2.Duracao = 200;

// albumDoQueen.AdicionarMusica(musica1);
// albumDoQueen.AdicionarMusica(musica2);

// albumDoQueen.ExibirMusicasDoAlbum();

// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();
// queen.AdicionarAlbum(albumDoQueen);
// queen.ExibirDiscografia();
