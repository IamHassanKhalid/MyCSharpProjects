using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEC_15
{
    class EXAMPLE
    {
        int data;
        public EXAMPLE()
        {
            data = 0;
        }
        public EXAMPLE(int x)
        {
            data = x;

    }
        public EXAMPLE(EXAMPLE obj)
        {
            data = obj.data;
        }
        public int display()
        {
            return data;
        }
    }
}
