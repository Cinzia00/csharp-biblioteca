using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Documento
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Sector { get; set; }
        public string Shelf { get; set; }
        public string Author { get; set; }



        public Documento(string code, string title, string year, string sector, string shelf, string author)
        {
            Code = code;
            Title = title;
            Year = year;
            Sector = sector;
            Shelf = shelf;
            Author = author;
        }

    }
}
