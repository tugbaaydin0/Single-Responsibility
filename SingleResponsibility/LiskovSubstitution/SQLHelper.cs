using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class SQLHelper: DBHelper
    {
        public override void Connect()
        {
            Console.WriteLine("SQL'e bağlan");
        }
        public override void Query()
        {
            Console.WriteLine("T-SQL");
        }
    }
}
