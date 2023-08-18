using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıfrelemeKotu
{
    public interface ISifreci
    {
        string Sifrele(string sifrelenecekMetin);
        string Coz(string cozulecekMetin);
    }

}
