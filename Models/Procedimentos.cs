public class Procedimentos
{
    public Guid Id { get; set; }
    public string Nome { get; set; }

    public Procedimentos(string nome)
    {
        Nome = nome;
    }
}