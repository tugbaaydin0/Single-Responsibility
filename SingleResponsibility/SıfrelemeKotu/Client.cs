using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıfrelemeKotu
{
    internal class Client
    {
        private List<ISifreci> sifreciler = null;
        public Client(List<ISifreci> sifreciler)
        {
            this.sifreciler = sifreciler;
        }
        public void Test()
        {
            List<string> sifreliMetinler = new List<string>;
            List<string> cozulenMetinler = new List<string>;
            sifreciler.ForEach(i =>
            {
                if (!(i is Sifreci3))
                    sifreliMetinler.Add(i.Sifrele("deneme"));
            });
            int sayi = 0;
            for(int i = 0; i < sifreciler.Count; i++)
            {
                if (!(sifreciler[i] is Sifreci3))
                {
                    cozulenMetinler.Add(sifreciler[i].Coz(sifreliMetinler[sayi]);
                    sayi++;
                }
            }
        }
    }
}
