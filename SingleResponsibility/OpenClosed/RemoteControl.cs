using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class RemoteControl
    {
        /*delegasyon islemi için RemoteControlInterface tipinde bir sınıf değişkeni tanımlıyoruz.
         Tüm işlemler bu nesnenin metodlarına delege edilir.*/
        private RemoteControlInterface remote;
        public RemoteControl(RemoteControlInterface _remote)
        {
            this.remote = _remote;
        }
        /**Aleti açmak için kullanılan metot.**/
        public void on()
        {
            remote.on();
        }
        /**Aleti kapatmak için kullanılan metot.**/
        public void off()
        {
            remote.off();
        }
    }
}
