using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Pole
    {
        Random rand = new Random();

        int[] massa;
        public static int[][] massaAll;
        public int[] Massa

        { 
            get { return massa; } set { massa = value; }      // Свойство . get - отдает, set - присваивает
        }   
        public int[][] MassaAll      
        { 
            get { return massaAll; } set { massaAll = value; } 
        
        }

        public Pole(int[] massa)   // Конструктор класса

        {
            this.Massa = massa;           
        }

        public Pole(int[][] massaAll) 
        {
            this.MassaAll = massaAll;
        }

        public void Sbor(int[][] massaAll)
        {
            for (int i = 0; i < massaAll.Length; i++)
            {
                for (int j = 0; j < massaAll[i].Length; j++)
                {
                    massaAll[i][j] = 0;  // Сбор всей грядки 
                }
            }



        }
        public void Posadka(int[][] massaAll)
        {
            for (int i = 0; i < 3; i++)
            {
                if (massaAll[i].Length == 3)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        massaAll[i][j] = rand.Next(2, 4); // Свекла
                    }
                }

                if (massaAll[i].Length == 6)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        massaAll[i][j] = rand.Next(2, 5); // Морковь
                    }
                }

                if (massaAll[i].Length == 8)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        massaAll[i][j] = rand.Next(1, 4); // Горох
                    }
                }
            }

        }
        public void ProvPol(int[][] massaAll)
        {
            int a = 0;
            for (int i = 0; i < massaAll.Length; i++)
            {
                for (int j = 0; j < massaAll[i].Length; j++)
                {


                    if (massaAll[i][j] == 0)
                    {
                        Console.WriteLine("Грядка не засажена");
                        break;
                    }


                }
                break;

                Console.WriteLine();
            }


        }

        public void Sbor()
        {
            for (int i = 0; i < massa.Length; i++)
            {
                massa[i] = 0;
            }
        }
        public void Posadka()
        {
            for (int i = 0; i < massa.Length; i++)
            {
                massa[i] = rand.Next(2, 4); 
            }
           
        }

        public void ProvPol()
        {
            int a = 0;
            for (int j = 0; j < massa.Length; j++)
            {
                if (massa[j] == 0)                
                {
                    Console.WriteLine("Поле не засажено");
                    break;
                }

            }          

        }

    }
}
