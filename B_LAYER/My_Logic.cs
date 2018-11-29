using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D_LAYER;

namespace B_LAYER
{
    class My_Logic
    {
        public string logic(string m)
        {
            datahandler d = new datahandler();
            return d.datasave(m);
        }
    }
}
