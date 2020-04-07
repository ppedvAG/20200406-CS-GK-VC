using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Library
{
    public class MyClassWProps
    {
        //prop Tab Tab
        public string MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }

        public bool MyProperty3 { get; set; }

        //ctortab tab
        public MyClassWProps(string prop1, int prop2)
        {
            MyProperty1 = prop1;
            MyProperty2 = prop2;
            MyProperty3 = false;
        }

        //~ tab
        ~MyClassWProps()
        {
            Console.WriteLine("Instanz der Klasse sagt Tschüss");
        }
    }
}
