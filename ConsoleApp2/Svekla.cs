using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp2
{
    public class Svekla: Pole  // public - идентификатор доступа
    {
        int[] massa;
        public int[] Massa

        { get { return massa; } set { massa = value; } }
        public Svekla(int[] massa) : base(massa)   // Конструктор класса

        {
            this.Massa = massa;
            foreach (int i in massa)
            {
                Console.WriteLine("Свекла весом: " + i);
            }
        }
    }
}
