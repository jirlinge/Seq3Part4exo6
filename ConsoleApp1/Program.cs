using System;

namespace ConsoleApp1
{
    class Program
    {

        enum week
        {
            Lundi, //Valeur1 vaut 0
            Mardi, //Valeur2 vaut 1
            Mercredi, //Valeur3 vaut 2
            Jeudi, //Valeur4 vaut 3
            Vendredi, //Valeur5 vaut 4
            Samedi, //Valeur6 vaut 5
            Dimanche, //Valeur7 vaut 6
        }

        static void Main(string[] args)
        {
          
            //week nomVariable = week.Valeur3;
            foreach (string i in Enum.GetNames(typeof(week)))
                Console.WriteLine(i);
            Console.WriteLine(Enum.GetNames(typeof(week)).GetValue(4));
        }
    }
}
