using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_LAB10_NatashaOstrander
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle fiesta = new Vehicle("Ford", "Fiesta", "black", "car", 120);
            Vehicle silverado = new Vehicle("Chevy", "Silverado", "green", "truck", 140);
            Vehicle sedona = new Vehicle("Kia", "Sedona", "red", "SUV", 120);
            Vehicle compass = new Vehicle("Jeep", "Compass", "white", "CUV", 130);
            Vehicle caravan = new Vehicle("Chevy", "Grand Caravan", "blue", "van", 120);

            fiesta.mySpeed.x = 0;
            string key = "";
            while (key != "q")
            {
                fiesta.ToString();
                Console.WriteLine("Press a key to interact with car");
                key = Console.ReadLine();

                if (key == "u" || key == "d" || key == "w" || key == "e" || key == "s" || key == "n")
                {
                        fiesta.mySpeed.move(key);
                }
                else
                {
                        Console.WriteLine("Invalid key stroke!");
                 }
              }

            }
        }
    }
}
