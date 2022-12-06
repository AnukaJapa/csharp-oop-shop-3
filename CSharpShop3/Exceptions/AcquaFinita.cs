using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3.Exceptions
{
    public class AcquaFinita :Exception
    {
        public AcquaFinita() { }
        public AcquaFinita(string message) : base(message) { }
    }
}
