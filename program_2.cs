using System;

namespace Loop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
            PrintTree(8);
        }



//FUNCTIONS
//PRINTNATURAL
        public static void PrintNatural(int n)
        {
            
            for (int count = 1; count <= n; count++)
            {
                Console.Write(" {0}" ,count);
            }
        }
 //==========================================================================       

//PRINTPRIMES        
        public static void PrintPrimes(int n)
        {
            for (int count = 1; count <= n; count++)
            {
                if (IsPrime(count))
                {
                    Console.Write(" {0}", count);
                }
                
            }
        } 
//PRINTPRIMES'S FUNCTIONS        

//ISPRIME
        public static bool IsPrime(int n)
        {
            bool res = true;
            
            for (int i = 3; i <= n; i++)
            {
                if (n % i != 0)
                {
                    res = false;
                }
            }
            return res;
        }
        
        
        
        
        
//Fibonacci
//PrintStrong
//ABS
//SQRT
//Power








//PRINTTREE
        public static void PrintTree(int n)
        {
            for (int ii = 0; ii != (n - 1); ii++)
            {
                Console.Write(" ");
            }

            int iii = (n - 1); 
            int star = 1;
            int etage = 1;

            while (etage < (n + 1))
            {
                //Afficher n fois l'espace
                for (int ii = 0; ii != iii; ii++)
                {
                    Console.Write(" ");
                }
                iii--;
                
                
                //Faire un etage    
                for (int i = 0; i != star; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                star = star + 2;
                etage++;
            }

            if (n == 3)
            {
                //Afficher n fois l'espace
                for (int ii = 0; ii != (n - 1); ii++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");  
            }
            else
            {
                //Afficher n fois l'espace
                for (int ii = 0; ii != (n - 1); ii++)
                {
                    Console.Write(" ");
                }
                Console.Write("*\n");
                for (int ii = 0; ii != (n - 1); ii++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
            }
            
        }
        
        
        
        
        
    }
}