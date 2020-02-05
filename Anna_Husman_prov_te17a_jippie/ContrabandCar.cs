using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Husman_prov_te17a_jippie
{
    class ContrabandCar : Car
    {
        public ContrabandCar() // gör en metod av contrabandbilen
        {

        }
       public int ContrabandAmount() // kollar hur mycket kontraband denna har, vilket enligt instruktion är någonstans mellan 1 -4 
        {
            return generator.Next(1, 4);
        }
    }
}
