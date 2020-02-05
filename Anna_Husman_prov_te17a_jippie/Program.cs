using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Husman_prov_te17a_jippie
{
    class Program // var tyvärr såhär mycket jag hann, hängde HELT upp mig på boolen så vet definitivt vad jag ska öva nu! 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många bilar ska skapas?");
            String ManyCars = Console.ReadLine(); // input från spelaren skapar x antal bilar 

            if (ManyCars != "1" && ManyCars != "2" && ManyCars != "3" && ManyCars != "4" && ManyCars != "5") // ser till att spelarna antingen väljer ett tal från 1 till 5
            {
                Console.WriteLine("Uh oh, det är inte rätt. Försök igen!"); // om dem ej följer mina instruktioner
            }
            else if( ManyCars == "1" && ManyCars == "2" && ManyCars == "3" && ManyCars == "4" && ManyCars == "5") // om dem följer mina instruktioner 
            {
                Console.WriteLine("Du har valt såhär många bilar: " + ManyCars); // får dem gå vidare! 
            }



            bool AlreadyChecked = true; // får inte boolen att fungera för någon anledning i klassen car, så testar att skriva den här o ser om jag kan lösa problemet. 
            if (AlreadyChecked)
            {
                Console.WriteLine("Sorry, Du har kollat den här bilen");
            }
            else
            {
               // Console.WriteLine("Den här bilen innehåller så här många kontraband: " + Contrabandamount);
            }

            List<string> Bilar = new List<string>(); // skapar en lista där jag lägger in max 5 bilar, då jag enbart kommer låta spelare välja mellan 1-5 

            Bilar.Add("Bil 1");
            Bilar.Add("Bil 2");
            Bilar.Add("Bil 3");
            Bilar.Add("Bil 4");
            Bilar.Add("Bil 5");
            Bilar.Add("Bil 6");
            Bilar.Add("Bil 7");













        }
    }
}
