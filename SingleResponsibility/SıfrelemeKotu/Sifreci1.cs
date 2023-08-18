using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıfrelemeKotu
{
    internal class Sifreci1:ISifreci
    {
       
        public string Sifrele(string sifrelenecekMetin)
        {
            return sifrelenecekMetin+" sifre";
        }
        public string Coz(string cozulecekMetin)
        {
            return cozulecekMetin.Substring(0, cozulecekMetin.Length - 5);
        }
    }
}
