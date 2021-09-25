using System;
using System.IO;
using System.Linq;
using static P1.Entree;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePath = "Users/clayt/Downloads/EntreesTabDelimited.txt";

            Entree[] nice = SetUp(filePath);

            /*string name = "Peanut Butter and Jelly";
            string[] arr = new string[] { "milk", "soy", "lentils", "beans", "veggies" };
            uint[] arr1 = new uint[] { 0, 12, 12, 1, 0, 0, 0, 2, 5, 3, 67, 3 };
            Entree food = new Entree(name, arr, arr1);
            Console.WriteLine(food.Contains("milk"));*/
        }

        static public Entree[] SetUp(string filePath)
        {
            Entree[] Arr = new Entree[] { };
            bool reading = true;
            char[] delimiter = new char[] { '\t' };

            try
            {
                StreamReader sr = new StreamReader("C:\\" + filePath);

                string[] line = sr.ReadLine().Split(delimiter);

                while (line != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        Console.WriteLine(line[i]);
                    }
                    line = sr.ReadLine().Split(delimiter);
                }

                sr.Close();
                Console.ReadLine();


            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            while (reading)
            {

                string name = "";
                string[] ingredients = new string[] { };
                uint[] nutritionStats = new uint[12];
                

                Entree food = new Entree(name, ingredients, nutritionStats);

                Arr.Append(food);

                //if end of file, break out of while loop

            }

            return Arr;
        }
    }
}
