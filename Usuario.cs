class Usuario
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int HistoricoDeReproducao { get; set; }
    public int PlaylistsCriadas { get; set; }

    public Usuario(string nome, string email, int playlistsCriadas, int historicoDeReproducao)
    {
        Nome = nome;
        Email = email;
        HistoricoDeReproducao = historicoDeReproducao;
        PlaylistsCriadas = playlistsCriadas;

    }
}