using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Prestito
    {
        public Utente User { get; set; }
        public Documento Document { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime Duedate { get; set; }
        public string StartDate { get; set; }
        public string DueDate { get; set; }




        public Prestito(Utente user, Documento document)
        {
           this.User = user;
           this.Document = document;
           this.StartDate = "12/09/2023";
           this.DueDate = "19/09/2023";
        }

     

    }
}
