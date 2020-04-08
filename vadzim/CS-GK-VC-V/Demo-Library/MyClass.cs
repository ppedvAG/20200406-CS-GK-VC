using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Library
{
    public class MyClass
    {
        string test = "bin ich privat?"; // Variablen ohne Modifier sind private

        // fields, sind immer private, klein geschrieben
        private string str_Field;
        private int int_Field;
        // props / Eigenschaften, groß geschrieben
        // constructor, implicit wird automatisch angelegt        
        // methoden       
        public void SetFields(string arg1, int arg2)
        {
            str_Field = arg1;
            int_Field = arg2;
        }
        public string GetFields()
        {
            // return str_Field.ToString() + " " + int_Field.ToString();            
            if (str_Field == null)            
                str_Field = "null";            
            return str_Field + " " + int_Field;
        }
        // destructor, implicit wird automatisch angelegt
        

    }
}
