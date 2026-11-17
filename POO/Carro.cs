public class Carro
{
    public string Fabricante;
    public string Modelo;
    public int AnoFabricacao;
    public int AnoModelo;
    public double ValorVenda;
    public Motor Motor;

    //public Carro(string c, int p, int ci)
    //{
    //    Motor = new(c, p, ci);
    //}

    public Carro(Motor m)
    {
        Motor = m;
    }

    public void setFabricante(string fabricante)
    {
        Fabricante = fabricante;
    }

    public void setModelo(string modelo)
    {
        Modelo = modelo;
    }

    public void setAnoFabricacao(int ano)
    {
        AnoFabricacao = ano;
    }

    public void setAnoModelo(int ano)
    {
        if (ValidarAnoModel(ano))
            AnoModelo = ano;
        else
            AnoModelo = AnoFabricacao;
    }

    private bool ValidarAnoModel(int ano)
    {
        if (ano == AnoFabricacao || ano == AnoFabricacao + 1)
            return true;
        else
            return false;
    }

    public void setValorVenda(double valor)
    {
        ValorVenda = valor;
    }

    public string getFabricante()
    {
        return Fabricante;
    }
    public string getModelo()
    {
        return Modelo;
    }

    public int getAnoFabricacao()
    {
        return AnoFabricacao;
    }

    public int getAnoModelo()
    {
        return AnoModelo;
    }
    public double getValorVenda()
    {
        return ValorVenda;
    }

    public override string ToString()
    {
        return $"Fabricante: {this.Fabricante}\nModelo: {this.Modelo}" +
            $"\nFabricacao: {this.AnoFabricacao}\nAno Modelo: {AnoModelo}" +
            $"\nValor: {this.ValorVenda}";
    }
}