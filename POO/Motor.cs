public class Motor
{
    public int Cilindrada;
    public int Potencia;
    public string Combustivel;

    public override string ToString()
    {
        return $"Motor:\n{Cilindrada} cc\nPotencia: {Potencia} cv\n" +
            $"Combustível: {Combustivel}";
    }

    public Motor (string c, int p, int ci)
    {
        Cilindrada = ci;
        Potencia = p;
        Combustivel = c;

    }

    public Motor()
    {

    }

    public Motor (int ci)
    {
        Cilindrada = ci;
    }

}