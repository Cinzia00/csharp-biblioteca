// See https://aka.ms/new-console-template for more information
using csharp_biblioteca;

Documento libro = new Libro("03258", "Il mondo di Pippo", "2020", "Avventura", "04", "Gino Gino", 1500);
Documento libro1 = new Libro("85458", "Mare blu", "2015", "Drammatico", "09", "Gina Gina", 350);
Documento libro2 = new Libro("89966", "Mare azzurro", "2013", "Drammatico", "09", "Tina Tina", 500);

List<Documento> libri = new List<Documento> { libro, libro1, libro2 };
List<Biblioteca> biblioteca = new List<Biblioteca> {};

Documento libro3 = new Libro("58846", "Guerra delle due rose", "2000", "Storia", "01", "Robert Gall", 500);
libri.Add(libro3);

static void PrintDocument(List<Documento> documenti)
{
    foreach(Documento documento in documenti) 
    {
        Console.WriteLine($"Titolo libro: {documento.Title}");
        Console.WriteLine($"Anno: {documento.Year}");
        Console.WriteLine($"Settore: {documento.Sector}");
        Console.WriteLine($"Autore: {documento.Author}");
        Console.WriteLine("-----------");
    }
}

Biblioteca biblioteca1 = new Biblioteca();

//biblioteca1.AddDocument(Documento documento);
