﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_LAYER
{
    public class Facade
    {
        private Facade f = new Facade();
        public static Facade instance = null;
        public static Facade getcontroller()
        {
            if (instance == null)
                instance = new Facade();
            return instance;
        }

        public string my_message(string m)
        {
            m = "";
            return m;
        }
    }
}
