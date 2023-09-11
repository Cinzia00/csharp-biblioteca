using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_biblioteca
{
    public class Biblioteca
    {
        List<Documento> documenti = new List<Documento> { };
        List<Utente> utenti = new List<Utente> { };
        List<Prestito> prestiti = new List<Prestito> { };


        public void AddDocument(Documento document)
        {
           documenti.Add(document);
        }

        public void AddUser(Utente user)
        {
            utenti.Add(user);

        }
        public void AddLoan(Prestito loan) 
        {
            prestiti.Add(loan);

        }

        internal void AddDocument(Documento documento, object libro4)
        {
            throw new NotImplementedException();
        }
    }
}
