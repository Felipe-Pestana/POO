Carro CadastrarCarro()
{
    Console.WriteLine("Informe o Fabricante: ");
    string fab = Console.ReadLine();
    Console.WriteLine("Informe o Modelo: ");
    string mod = Console.ReadLine();
    Console.WriteLine("Informe o Ano de Fabricacao: ");
    int anofab = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o Ano do Modelo: ");
    int anomod = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o Valor de Venda: ");
    double preco = double.Parse(Console.ReadLine());

    Carro c = new();

    c.setFabricante(fab);
    c.setModelo(mod);
    c.setAnoFabricacao(anofab);
    c.setAnoModelo(anomod);
    c.setValorVenda(preco);

    return c;
}

Carro[] carros = new Carro[4];

for(int i = 0;  i < carros.Length; i++)
{
    carros[i] = CadastrarCarro();
}

void MostrarCarros()
{
    for(int i = 0; i < carros.Length; i++)
    {
        Console.WriteLine(carros[i]);
    }
}

MostrarCarros();