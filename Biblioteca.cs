using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_biblioteca
{
    public class Biblioteca
    {
        public List<Documento> Documents { get; set; } = new List<Documento>();
        public List<Utente> Users { get; set; }  = new List<Utente>();
        public List<Prestito> Loans { get; set; } = new List<Prestito>();


        public void AddDocument(Documento document)
        {
            Documents.Add(document);
        }

        public void AddUser(Utente user)
        {
            Users.Add(user);
        }

        public void AddLoan(Utente user, Documento document) 
        {
            Prestito prestito = new Prestito(user, document);
            Loans.Add(prestito);
        }

        public void PrintDocument()
        {
            foreach (Documento documento in this.Documents)
            {
                Console.WriteLine($"Titolo: {documento.Title}");
                Console.WriteLine($"Anno: {documento.Year}");
                Console.WriteLine($"Settore: {documento.Sector}");
                Console.WriteLine($"Autore: {documento.Author}");
                Console.WriteLine("-----------");
            }
        }

        public void PrintUser()
        {
            foreach (Utente user in this.Users)
            {
                Console.WriteLine($"Cognome: {user.LastName}");
                Console.WriteLine($"Nome: {user.Name}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"Telefono: {user.Phone}");
                Console.WriteLine("-----------");
            }
        }

        public void PrintLoan()
        {
            foreach (Prestito loan in this.Loans)
            {
                Console.WriteLine($"Cognome e Nome: {loan.User.fullName()}");
                Console.WriteLine($"Documneto in prestito: {loan.Document.Title}");
                Console.WriteLine($"Data inizio prestito: {loan.StartDate}");
                Console.WriteLine($"Data fine prestito: {loan.DueDate}");
                Console.WriteLine("-----------");
            }
        }




    }
}
