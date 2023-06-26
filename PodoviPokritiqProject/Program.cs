using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoviPokritiqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PodoviPokritiq> podoviPokritiq = new List<PodoviPokritiq>();
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Въведете данните за подовото покритие");
                    Console.Write("Тип: ");
                    string productType = Console.ReadLine();
                    Console.Write("Материал: ");
                    string materialType = Console.ReadLine();
                    Console.Write("Цвят: ");
                    string color = Console.ReadLine();
                    Console.Write("Дължина: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Ширина: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Цена: ");
                    double price = double.Parse(Console.ReadLine());
                    break;
            }
        }
    }
}
