using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Prestito
    {
        public string Period { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }


        public Prestito(string period)
        {
            this.Period = period;
        }

     
    }
}
