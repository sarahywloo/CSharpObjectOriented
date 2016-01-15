using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount {
    class Program {
        static void Main(string[] args) {

            //Counting Words in a String
            Console.WriteLine(Counter.CountWords("Hello World!"));
            Console.WriteLine(Counter.CountWords("The Cat in the Hat"));

            //Extension methods
            Console.Write("The quick brown fox".WordCount());
            foreach (var word in "The quick brown fox jumps over the lazy dog".GetFirstWords(4)) { 
                Console.Write(word);
            }
            

            //Car Class: How interfaces work
            var car = new CertifiedUsedCar {
                VIN = "XXXXXXXX1234xxx",
                Model = "BMW",
                Price = 50000m,
                Miles = 4000,
                WarrantyMonths = 12
            };

            var usedCar = new UsedCar {
                VIN = "XXXX00X00",
                Price = 10000m
            };
            var tax = usedCar.CalculateTax();

            var inventory = new Car[] {
                new UsedCar { VIN="78YSDDFSD45", Price=17000m },
                new CertifiedUsedCar { VIN="888SDDFSD45", Price=17000m },
                new NewCar { VIN="YIUIU66II77", Price=44000m },
                new UsedCar { VIN="3NBMM99887", Price=12000m },
                new UsedCar { VIN="55555OOOOOP", Price=11000m }
            };

            var total = 0m;
            foreach (var usedcar in inventory) {
                total += usedcar.Price;
            }
            Console.WriteLine("Total inventory value: " + total.ToString("c"));

            Console.ReadLine();
        }

        //Example of typecasting:
        //public static void PrintMiles(Car car) {
        //    Console.WriteLine(((UsedCar)car).Miles);
        //}
    }
}
