// See https://aka.ms/new-console-template for more information
using csharp_biblioteca;

Libro libro1 = new Libro("03258", "Il mondo di Pippo", "2020", "Avventura", "04", "Gino Gino", 1500);
Libro libro2 = new Libro("85458", "Mare blu", "2015", "Drammatico", "09", "Gina Gina", 350);
Libro libro3 = new Libro("89966", "Mare azzurro", "2013", "Drammatico", "09", "Tina Tina", 500);

Dvd dvd1 = new Dvd("03258", "Il mondo di Pippo", "2020", "Avventura", "04", "Gino Gino", 1500);
Dvd dvd2 = new Dvd("85458", "Mare blu", "2015", "Drammatico", "09", "Gina Gina", 350);
Dvd dvd3 = new Dvd("89966", "Mare azzurro", "2013", "Drammatico", "09", "Tina Tina", 500);

Utente utente1 = new Utente("Rossi", "Mario", "jnj@gmail.com", 115651, 033255);



Libro libro4 = new Libro("58846", "Guerra delle due rose", "2000", "Storia", "01", "Robert Gall", 500);




Biblioteca biblioteca1 = new Biblioteca();

biblioteca1.AddDocument(libro1);
biblioteca1.AddDocument(libro2);
biblioteca1.AddDocument(libro3);
biblioteca1.AddDocument(libro4);
biblioteca1.PrintDocument();

biblioteca1.AddUser(utente1);
biblioteca1.PrintUser();
biblioteca1.AddLoan(utente1, libro3);
biblioteca1.PrintLoan();