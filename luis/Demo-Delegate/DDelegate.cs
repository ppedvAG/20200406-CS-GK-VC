using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate
{
    class Program
    {

        #region Step1
        // Bsp-Methoden um Delegaten zu demonstrieren

        public static int Addiere(int a, int b)
        {
            Console.WriteLine($"Addieren: {a + b}");
            return a + b;
        }



        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine($"Subtrahieren: {a - b}");
            return a - b;
        }

        #endregion


        #region step2
        // Delegate ist eine Variable / Klasse,
        // in der man Funktionen mit gleichem Methodenkopf speichern kann.
        // eigene Delegate-Typen müssen vorher definiert werden.
        public delegate int MyDelegate(int a, int b);
        #endregion



        #region Callbacks in C# way Step1
        public static void FühreAus(Func<int, int, int> auszuführendeMethode)
        {
            int result = auszuführendeMethode(23, 43);
            Console.WriteLine("result aus FühreAus" + result);
        }
        #endregion



        #region Lists & Delegates Step 1
        public static bool SucheStadtMitH(string stadt)
        {
            return stadt.StartsWith("H");
        }
        #endregion



        static void Main(string[] args)
        {




            #region step3
            Console.WriteLine(" ### Step 3 ### ");

            // den Delegaten einsetzen
            MyDelegate delegateVariable = new MyDelegate(Addiere);  // Konstruktor von Delegaten erwartet den Namen einer Methode, die genau soviele Parameter wie bei der deklaration des Delegaten angegeben wurden.


            // den Delegaten ausführen
            // Die Instanz der Delegatenklasse funktioniert wie eine Funktion
            int ergebnis = delegateVariable(2, 3);
            Console.WriteLine(ergebnis);


            // Neuzuweisung der Variable
            // Die Instanz der Delegatenklasse kann auch andere Methoden annehmen und ausführen
            delegateVariable = Subtrahiere;
            ergebnis = delegateVariable(5, 2);
            Console.WriteLine(ergebnis);


            // Hinzufügen einer weiteren Methode zu der Variable
            delegateVariable += Addiere;
            // Ausgeführt werden die Methoden in gleichen Reihenfolge wie sie hinzugefügt worden sind
            // Aber nur Return von der letzten können wir abfangen
            ergebnis = delegateVariable(4, 4);
            Console.WriteLine(ergebnis);
            


            // Neuzuweisung der Variable
            // Die Instanz der Delegatenklasse kann auch andere Methoden annehmen und ausführen
            delegateVariable += Subtrahiere;
            ergebnis = delegateVariable(5, 2);
            Console.WriteLine(ergebnis);


            // Neuzuweisung der Variable
            // Die Instanz der Delegatenklasse kann auch andere Methoden annehmen und ausführen
            delegateVariable -= Subtrahiere;
            ergebnis = delegateVariable(5, 2);
            Console.WriteLine(ergebnis);

            // Neuzuweisung der Variable
            // Die Instanz der Delegatenklasse kann auch andere Methoden annehmen und ausführen
            delegateVariable -= Subtrahiere;
            ergebnis = delegateVariable(5, 2);
            Console.WriteLine(ergebnis);

            #endregion



            #region Iteration of delegates
            Console.WriteLine(" ### Iteration of delegates ### ");
            
            foreach (var item in delegateVariable.GetInvocationList().ToList())
            {
                Console.WriteLine(item.Method);
            }
            #endregion


            #region Clear Delegaten-Instanz
            Console.WriteLine(" ### Delegaten leeren ### ");
            delegateVariable = null;
            #endregion


            #region eingebaute Delegaten
            Console.WriteLine(" ### eingebaute Delegaten ### ");

            Func<int, int, int> meinFunc = Addiere;
            meinFunc += Subtrahiere;
            Console.WriteLine(meinFunc(34, 32));
            #endregion


            #region Callbacks in C# way Step2
            Console.WriteLine(" ### Callbacks in C# way Step2 ### ");
            
            Console.WriteLine(" FühreAus(Addiere):");
            FühreAus(Addiere);
            
            Console.WriteLine("FühreAus(meinFunc): ");
            FühreAus(meinFunc); // Praktischer Nutzen wäre bei diesem Szenario 

            Console.WriteLine("FühreAus(meinFunc): ");
            FühreAus(meinFunc);

            #endregion



            #region Lists & Delegates Step 2
            Console.WriteLine(" ### LISTS & DELEGATES ### ");
            List<string> Städteliste = new List<string>() { "Karlsruhe", "Hamburg", "Bremen" };
            string gefundeneStadt = Städteliste.Find(SucheStadtMitH);
            Console.WriteLine(gefundeneStadt);



            // Variante 2, ohne vordefinierte Methode, Übergabe einer Methode als anonyme Methode
            gefundeneStadt = Städteliste.Find(
                delegate (string stadt)
                {
                    return stadt.StartsWith("K");
                });
            Console.WriteLine(gefundeneStadt);




            // Variante 3, Übergabe einer anonymen Methode als Arrow Function / Pfeilfunktion / Lambda
            // Ausführliche Syntax von Pfeilfunktion
            gefundeneStadt = Städteliste.Find((string stadt) => { return stadt.StartsWith("B"); });
            Console.WriteLine(gefundeneStadt);

            // Wenn die Pfeilfunktion nur einen Argumenten bekommt, dann die runden Klammern optional
            // Wenn in der Funktion nur eine Anweisung ausgeführt wird, 
            // dann return und die geschweiften Klammern und Semikolonsind auch optional
            gefundeneStadt = Städteliste.Find(stadt => stadt.StartsWith("B"));



            Städteliste = Städteliste.OrderBy(stadt => stadt[0]).ToList();
            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.ReadKey();







        }
}
}
