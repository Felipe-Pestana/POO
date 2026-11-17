public abstract class Pessoa
{
    public string Name { get; set; }
    public string Address {  get; set; }
    public DateOnly Date { get; set; }
    public string Phone {  get; set; }

    public Pessoa(string n)
    {
        Name = n;
        Date = DateOnly.FromDateTime(DateTime.Now);
    }
    public Pessoa(string n, string p)
    {
        Name = n;
        Phone = p;
    }

    public override string ToString()
    {
        return $"Nome:{this.Name}\n" +
            $"Data de Criacao: {this.Date}\n" +
            $"Telefone: {this.Phone}";
    }
}
