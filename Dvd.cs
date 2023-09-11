using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Documento
    {
        public int duration;


        public Dvd(string code, string title, string year, string sector, string shelf, string author, int duration) : base(code, title, year, sector, shelf, author)
        {
            this.duration = duration;
        }


        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if(value > 0)
                {
                    this.duration = value;
                }
            }
        }
    }
}
