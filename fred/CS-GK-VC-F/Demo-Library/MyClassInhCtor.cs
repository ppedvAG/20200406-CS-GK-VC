using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Library
{
    public class MyClassInhCtor : MyClassWProps
    {

        public double MyDblMProperty { get; set; }
        public MyClassInhCtor(string prop1, int prop2, double prop3) : base(prop1, prop2)
        {
            MyDblMProperty = prop3;

        }

        public string Beschreibemich()
        {
            return $@"
prop1: {MyProperty1}
prop2: {MyProperty2}
prop3: { MyProperty3}
prop4: { MyDblMProperty}";
        }

    }
}
