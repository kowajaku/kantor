using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kantor
{
    public class Stan_walut_kantoru
    {
        public double PLN { get; set; }
        public double USD { get; set; }
        public double EUR { get; set; }
        public double GBP { get; set; }
        public double CHF { get; set; }

        public Stan_walut_kantoru()
        {
            
            PLN = -1;
            USD = -1;
            EUR = -1;
            GBP = -1;
            CHF = -1;
        }
       
    }
}
