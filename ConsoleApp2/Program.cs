using ConsoleApp2;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args) // метод 
    {
        Random rand = new Random();    

        int[][] gryadka = new int[3][];   //3 - поля
        gryadka[0] = new int[3]; // 3 - это Свекла
        gryadka[1] = new int[6]; // 6 - это Морковь
        gryadka[2] = new int[8]; // 8 - это Горох

        for (int i = 0; i < 3; i++)
        {
            if (gryadka[i].Length == 3)
            {
                for (int j = 0; j < 3; j++)
                {
                    gryadka[i][j] = rand.Next(2, 4); // Свекла
                }
            }

            if (gryadka[i].Length == 6)
            {
                for (int j = 0; j < 6; j++)
                {
                    gryadka[i][j] = rand.Next(2, 5); // Морковь
                }
            }

            if (gryadka[i].Length == 8)
            {
                for (int j = 0; j < 8; j++)
                {
                    gryadka[i][j] = rand.Next(1, 4); // Горох
                }
            }
        }

        Svekla svekla = new Svekla(gryadka[0]);
        Morkov morkov = new Morkov(gryadka[1]);
        Goroh goroh = new Goroh(gryadka[2]);
        Gryadka gryad = new Gryadka(gryadka);

        svekla.Sbor();
        svekla.ProvPol();              
        morkov.Sbor();
        morkov.ProvPol();
        goroh.Sbor();
        goroh.ProvPol();
        svekla.Posadka();
        
        morkov.Posadka();
       
        goroh.Posadka();
        
        gryad.Sbor(gryadka);
        gryad.ProvPol(gryadka);
        gryad.Posadka(gryadka);
        
    }
}