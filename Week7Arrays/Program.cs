using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //kasutaja kuvab kasutajale hommikusöögi menüüd
            //programm palub kasutajal valikut teha
            //programm kuvab kasutaja valikut konsoolis

            string[] menüü = { "omlett", "pannkoogid", "keedumuna", "neljaviljapuder", "singivõileib", };
            Console.WriteLine($"Meie menüüs on {menüü.Length} valikut");

            // menüü[4] = "juustuvõileib";
            // menüü[3] = "kaerapuder";

            Console.WriteLine("Tänases menüüs");

            for(int i = 0; i < menüü.Length; i++)
            {
                if (menüü[i] == "neljaviljapuder")
                {
                    menüü[i] = "kaerapuder";
                }
                else if (menüü[i] == "singivõileib")
                {
                    menüü[i] = "juustuvõileib";
                }

                Console.WriteLine(menüü[i]);
            }

            Console.WriteLine("Palun tehke oma valik (sisesta numbrit 1-5):");
            int valik = Convert.ToInt32(Console.ReadLine())-1;

            Console.WriteLine($"Oled valinud {menüü[valik]}");
            

            /*foreach(string menüüElement in menüü)
            {
                Console.WriteLine(menüüElement);
            }*/

        }
    }
}
