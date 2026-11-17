public class PessoaJuridica : Pessoa
{
    public string Alias { get; set; }
    public string CNPJ { get; set; }

    public PessoaJuridica(string n, string c) : base(n)
    {
        CNPJ = c;
    }
    public PessoaJuridica(string n, string c, string? a) : base(n)
    {
        CNPJ = c;
        if (string.IsNullOrEmpty(a))
            a = Name;
        Alias = a;
    }
}