using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Libro : Documento
    {
        private int pages;


        public Libro(string code, string title, string year, string sector, string shelf, string author, int pages) : base(code, title, year, sector, shelf, author)
        {
            this.pages = pages;
        }


        public int Pages
        {
            get {
                return this.pages; 
            }
            set 
            {
                if(value > 0)
                {
                    this.pages = value;
                }
            }
        } 



    }
}
