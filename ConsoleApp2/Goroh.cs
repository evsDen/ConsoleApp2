using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Goroh : Pole  // public - идентификатор доступа
    {
        int[] massa;
        public int[] Massa

        { get { return massa; } set { massa = value; } }
        public Goroh(int[] massa) : base(massa)   // Конструктор класса

        {
            this.Massa = massa;
           foreach (int i in massa) 
            { 
            Console.WriteLine("Горох весом: "+i);
            }
        }
    }
}
