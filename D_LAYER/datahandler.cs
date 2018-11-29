using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace D_LAYER
{
    public class datahandler
    {
        public string datasave(string m)
        {
            StreamWriter sw = new StreamWriter("hisham.txt");
            sw.WriteLine(m);
            sw.Close();
            return "DATA SAVED";
        }
    }
}
