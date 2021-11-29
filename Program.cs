using System;

namespace Uppdrag_2_Ett_aktivitetsdiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age:");//Ber användaren skriva in sin ålder
            int age = Convert.ToInt32(Console.ReadLine());//konverterar det användaren skriver till en int
            int money = 15000;//startvärde av pengarna
                              

            do
            {
                if (money > 20000 || age < 60) // om money är större än 20000 eller age är mindre 60
                {
                    Console.WriteLine("You are saving little"); //om if satsen stämmer så skrivs detta ut
                    money += 500; // ökar money 500 dollar
                    
                }
                else // annars
                {
                    Console.WriteLine("You are saving a lot");// skrivs detta ut
                    money += 1000; // ökar money med 1000 dollar
                    
                }



                age++; // ökar age med 1

            } while (money < 20000 && age < 65); //om money är mindre än 20000 och age är mindre än 65 år
            
            Console.WriteLine("You are retired by the age of " + age); //skrivs detta ut och åldern
            Console.WriteLine("You are saved " + money + " dollars"); //skrivs detta ut samt money
            
            

            Console.ReadKey(); // så programmet inte stängs av

        }
    }
}
