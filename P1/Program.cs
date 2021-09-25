using System;
using System.Linq;
using static P1.Entree;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePath = "";

            //SetUp(filePath);

            string name = "Peanut Butter and Jelly";
            string[] arr = new string[] { "milk", "soy", "lentils", "beans", "veggies" };
            uint[] arr1 = new uint[] { 0, 12, 12, 1, 0, 0, 0, 2, 5, 3, 67, 3 };
            Entree food = new Entree(name, arr, arr1);
            Console.WriteLine(food.Contains("milk"));
        }

        static public Entree[] SetUp(string filePath)
        {
            Entree[] Arr = new Entree[] { };
            bool reading = true;

            while (reading)
            {
                string name = "";
                string[] ingredients = new string[] { };
                uint[] nutritionStats = new uint[12];
                // read in data from text file

                Entree food = new Entree(name, ingredients, nutritionStats);

                Arr.Append(food);

                //if end of file, break out of while loop

            }

            return Arr;
        }
    }
}
