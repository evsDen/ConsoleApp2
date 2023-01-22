using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Gryadka : Pole
    {
        int[][] massa;
        public int[][] Massa

        { get { return massa; } set { massa = value; } }   // Свойство . get - отдает, set - присваивает

        public Gryadka(int[][] massa) : base(massaAll)   // Конструктор класса

        {
            this.Massa = massa; // Передаваемое значение свекла, мы присваиваем значение
            Console.WriteLine("Вывод всей грядки: \t");
            for (int i = 0; i < massa.Length; i++)  
            {
                for (int j = 0; j < massa[i].Length; j++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Свекла весом: " + massa[i][j]);
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine("Морковь весом: " + massa[i][j]);
                    }
                    else
                    {
                        Console.WriteLine("Горох весом: " + massa[i][j]);
                    }
                }
            }

        }

       
    }
}
