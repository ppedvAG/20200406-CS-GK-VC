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
            #region Class witout Constructor


            MyClass myClass = new MyClass(); //obwohl wir keinen Konstruktor angelegt hatten
            myClass.SetFields("Antwort ist ", 43);

            string str = myClass.GetFields();
            Console.WriteLine($"Felder von meiner Klasse: {str}");

            //string str = myClass.GetFields();
            //Console.WriteLine($"Felder von meiner Klasse: {str}");

            Console.ReadKey();
            #endregion

            #region Class with Props
            // Klasse muss public sein, damit sie aus anderen Namensräumen ansprechbar ist
            MyClassWProps myClassWProps = new MyClassWProps("ein super string", 3); // Standrad Konstruktor ist durch unseren überschrieben worden

            Console.WriteLine($"{myClassWProps.MyProperty3}");


            #endregion
            Console.ReadKey();
        }
    }
}
