using System;

namespace Demo_Library
{
    public class MyClass
    {
        // fields, sind immer private, klein geschrieben
        private string str_Field;
        private int int_Field;

        //props, Eigenschaften , groß geschrieben
        //constructor implizit wird automatisch angelegt
        //Methoden
        public void SetFields(string arg1, int arg2)
        {
            str_Field = arg1;
            int_Field = arg2;
        }

        public string GetFields()
        {
            return str_Field + " " + int_Field;
        }
        //destructor

    }
}
