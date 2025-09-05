class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public void DescricaoResumida { get; }



    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome} ");
        Console.WriteLine($"Artistta: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no Plano");
        }
        else
        {
            Console.WriteLine("Musica não disponível, consulte o seu plano");

        }

    }
}