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

            #region Inheritance Vererbung
            Random random = new Random();
            Console.WriteLine($"{random.Next(2, 3)}");

            MyRandom myRandom = new MyRandom();
            Console.WriteLine($"{myRandom.NextMaxInclusive(2,3)}");

            #endregion

            #region Inheritense with Constructor
            MyClassInhCtor myClassInhCtor = new MyClassInhCtor("mist1", 3, 5.4);
            Console.WriteLine(myClassInhCtor.Beschreibemich());

            #endregion

            Console.ReadKey();
        }
    }
}
