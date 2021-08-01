//import library
using System;
using System.Collections.Generic;
using System.Globalization;

//namespace here

namespace kurssintehtävä
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo culture = new CultureInfo("hr-HR");                     
            DateTime tanaan = DateTime.Today;                                   //määritellään päivämäärä-typpinen muttuja ja annetaan sille arvoksi kuluva päivä
            int arvausnumero = 0, arvausSumma=0, rluku= 0;                      // määritellään arvausnumero, arvaus summa ja rluku integer muuttuja
            Boolean lopeta = false;                                             //defining boolean as false continuing the loop
            Random random = new Random();                                       //Instantiate random number generator using system-supplied value as seed
            List<int> arvauslista = new List<int>();                            //määritellään int-tyyppinen lista

            for (;;)                                                            //using forever loop for continuation of the game
            {
                
                Console.WriteLine("Tervetuola ArvausPeli versio 1.00, " + tanaan.ToString("d",culture)); //welcome message with version and today's date
                rluku = random.Next(1, 100);                                    // Generates 1 random integer between 1 and 100.
                //Console.WriteLine("Your random numeber is {0}", rluku);

                //creating loop for the playing game
                while (lopeta != true)                                  
                {

                    Console.WriteLine("Anna arvausnumero 1-100");               //kysytään arvausneumero 1 -100
                    arvausnumero = int.Parse(Console.ReadLine());               //talletaan käytääjän antama vastaus nimi-muuttujaan sellaisenaan
                    arvauslista.Add(arvausnumero);                              //adding arvausnumero in the list
                    arvausSumma++;                                              //adding the number of times user guesses the number

                    //examine the value of guessing number and comparing with random generated integer
                    if (rluku < arvausnumero)
                    {
                        Console.WriteLine("Luku on pienempi kuin arvaus");                        
                    } 
                    else if (rluku > arvausnumero)
                    {
                        Console.WriteLine("Luku on suurempi kuin arvaus");
                    }
                    else
                    {
                        Console.WriteLine("Onnea! voitit {0} arvauksessa",arvausSumma);
                        for (int i = 0; i < arvauslista.Count; i++)                     // tulostaa listan sisällön 
                        {
                            Console.WriteLine(arvauslista[i]);

                        }
                        arvausSumma = 0;                                                // reset the arvaus summa value to 0
                        arvauslista.Clear();                                            //clearing the list after winning and showing the result
                        break;
                    }

                }

                Console.WriteLine();                                                //kirjoitetaan tyhjä rivi
                Console.WriteLine("Haetaanko Arvausluvut uudelleen? K=kyllä/E=ei"); //kysytään jos pelaa uudelleen
                //continuing the loop using k or exiting the game
                if (Console.ReadLine().ToUpper() == "K") lopeta = false;
                else
                    break;
                
            //Console.ReadLine();                   
         }
        }
    }
}