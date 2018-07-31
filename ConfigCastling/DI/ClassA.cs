using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigCastling.DI
{
    public class ClassA : IClass
    {
        public void SaySomething()
        {
            Console.WriteLine("A");
        }
    }
}
