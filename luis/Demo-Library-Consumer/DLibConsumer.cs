using Demo_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Library_Consumer
{
    class DLibConsumer
    {
        static void Main(string[] args)
        {

            #region Class without Constructor
            MyClass myClass = new MyClass();    //obwohl wir keinen Konstruktor angelegt hatten

            string str = myClass.GetFields();
            Console.WriteLine($"getFields: {str}");


            myClass.SetFields("Die Antowrt ist:", 43);

            str = myClass.GetFields();
            Console.WriteLine($"getFields: {str}");


            
            #endregion


            #region Class with Props
            MyClassWProps myClassWProps = new MyClassWProps("ein super string", 3);
            
         

            Console.WriteLine($"myClassWProps.MyProperty3: {myClassWProps.MyProperty1}");

            #endregion



            #region Vererbung
            
            Random random = new Random();
            Console.WriteLine($"{random.Next(1,3)}");

            MyRandom myRandom = new MyRandom();
            Console.WriteLine($"{myRandom.NextMaxInklusive(1, 3)}");


            MyClassInhCtor myClassInhCtor = new MyClassInhCtor("solala", 3, 5.4);
            Console.WriteLine($"{myClassInhCtor.BeschreibeMich()}");


            #endregion
            Console.ReadKey();
        }
    }
}
