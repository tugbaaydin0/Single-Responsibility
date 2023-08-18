using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class OracleHelper:DBHelper
    {
        public override void Connect()
        {
            Console.WriteLine("Oracle'a bağlan");
        }
        public override void Query()
        {
            Console.WriteLine("PL-SQL");
        }
    }
}
