class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome} ");
        Console.WriteLine($"Artistta: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponivel no Plano");
        }
        else
        {
            Console.WriteLine("Musica não disponível, consulte o seu plano");

        }

    }
}