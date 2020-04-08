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

            #region Call MyClass / Class without Constructor
            MyClass myClass = new MyClass(); // obwohl wir keinen Konstruktor angelegt hatten

            string str = myClass.GetFields();
            Console.WriteLine($"Felder von meiner Klasse: {str}"); // 0 für int, von str_Field kam nichts, weil es den null hat

            // myClass.SetFields("die Antwort ist: ", 43);

            str = myClass.GetFields();

            Console.WriteLine($"Felder von meiner Klasse: {str}");            
            #endregion


            #region Call MyClassWProps 
            // Klasse muss public sein, damit sie aus anderen Namensräumen ansprechbar ist
            MyClassWProps myClassWProps = new MyClassWProps("ein super string", 3); //Standard-Konstruktor ist mit unserem überschrieben worden
            
            Console.WriteLine($"myClassWProps.MyProperty3: {myClassWProps.MyProperty3}");

            myClassWProps = null; // *todo
            #endregion


            #region Inheritense / Call MyRandom
            Random random = new Random();
            Console.WriteLine($"{random.Next(2,3)}");
            MyRandom myRandom = new MyRandom();
            Console.WriteLine($"{myRandom.NextMaxInclusive(2,3)}");
            #endregion


            #region Inheritence / Call MyClassInhCtor
            MyClassInhCtor myClassInhCtor = new MyClassInhCtor("mist1", 3, 5.4);
            Console.WriteLine(myClassInhCtor.BeschreibeMich());
            #endregion

            Console.ReadKey();
        }
    }
}
