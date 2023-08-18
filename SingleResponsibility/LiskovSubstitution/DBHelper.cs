using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public abstract class DBHelper
    {
        public abstract void Connect();
        public abstract void  Query();
    }
}
