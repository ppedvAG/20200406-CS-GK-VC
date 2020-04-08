using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Library
{
    public class MyClassInhCtor : MyClassWProps
    {
        public double MyDblProperty { get; set; }
        
        public MyClassInhCtor(string prop1, int prop2, double prop3) : base(prop1, prop2)
        {
            MyDblProperty = prop3;
        }

        public string BeschreibeMich()
        {
            return $@"
prop1: {MyProperty1}
prop2: {MyProperty2}
prop3: {MyProperty3}
prop4: {MyDblProperty}
";
        }


    }
}
