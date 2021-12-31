using System;

namespace Assignment1_Q2Change
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the price: ");
            int Price = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Paid amount: ");
            int Paid = int.Parse(Console.ReadLine());

            int refound = Paid - Price;
            int chang = 0;
            Console.Write("change is: " + refound );
            do
            {
                chang = refound % 500;
                if (chang == 0)
                    continue;
                
                refound -= chang;

              
            } while (chang != 0);
                

                
           
                
              

            
     
        }
    }
}
