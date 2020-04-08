using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Library
{
    public class MyClassWProps
    {
        public string MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public bool MyProperty3 { get; set; }

        public MyClassWProps(string prop1, int prop2)
        {
            MyProperty1 = prop1;
            MyProperty2 = prop2;
            MyProperty3 = false;
        }
    }
}
