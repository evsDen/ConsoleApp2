using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Morkov : Pole  // public - идентификатор доступа
    {
        int[] massa;
        public int[] Massa

        { get { return massa; } set { massa = value; } }
        public Morkov(int[] massa) : base(massa)   // Конструктор класса

        {
            this.Massa = massa;
            foreach (int i in massa)
            {
                Console.WriteLine("Морковь весом: " + i);
            }
        }
    }
}
