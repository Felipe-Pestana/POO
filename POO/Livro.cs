public class Livro
{
    public string Titulo;
    public string Autor;
    public uint Paginas;


    public Livro(string t, string a, uint p)
    {
        Titulo = t;
        Autor = a;
        Paginas = p;
    }

    public string GetTitulo()
    {
        return this.Titulo;
    }

    public string GetAutor()
    {
        return Autor;
    }
    public uint GetPaginas()
    {
        return Paginas;
    }

    public override string ToString()
    {
        return $"""
            Titulo: {this.Titulo}
            Autor: {Autor}
            Qtd de Páginas: {GetPaginas()}    
            """;
    }
}