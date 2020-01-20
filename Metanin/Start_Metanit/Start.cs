using System;

namespace Start_Metanit
{
    class Start
    {
        static void Main (string [] args)
        {
            Console.WriteLine ("Hello World!");

            Console.Write ("Обозначься - ......");
            string str = Console.ReadLine ();
            Console.WriteLine ($"Привет, {str}");

            Console.ReadKey ();
        }
    }
}
