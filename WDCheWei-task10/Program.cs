using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDCheWei_task10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Opiskelijat> opiskelijaryhma = new List<Opiskelijat>()
            {
                new Opiskelijat("Jaakko Laaksonen", "Sammonkatu 5", new DateTime(1995,11,23)),
                new Opiskelijat("Minna Jaakkola", "Patteristonkatu 10", new DateTime(1991,10,25)),
                new Opiskelijat("Asko Liukkonen", "Kettukuja 15", new DateTime(1976,03,11)),
                new Opiskelijat("Elina Savela", "Kasarminkatu 20", new DateTime(2001,07,14)),
                new Opiskelijat("Santeri Kilpeläinen", "Porrassalmenkatu 25", new DateTime(1968,12,18)),
                new Opiskelijat("Sari Karasti", "Saimaannorpantie 30", new DateTime(1985,04,15)),
                new Opiskelijat("Marja Kosonen", "Saattotie 35", new DateTime(1957,08,12)),
                new Opiskelijat("Riiko Lappalainen", "Savilahdenkatu 40", new DateTime(2002,05,20)),
                new Opiskelijat("Onerva Rantanen", "Jääkärinkatu 13", new DateTime(1988,08,18)),
                new Opiskelijat("Tuulia Tuominen", "Kuistinkuja 47", new DateTime(1979,11,12)),
                new Opiskelijat("Pyry Ojala", "Suur-Savonkatu 7", new DateTime(1994,06,23)),
                new Opiskelijat("Touko Hiltunen", "Tykkimiehenkatu 17", new DateTime(1965,12,12)),
                new Opiskelijat("Kerkko Kauppinen", "Sointukatu 12", new DateTime(1963,06,06)),
                new Opiskelijat("Visa Lahti", "Brahenkatu 9", new DateTime(1959,09,29)),
                new Opiskelijat("Ohto Lahti", "Brahenkatu 7", new DateTime(1958,08,16)),
                new Opiskelijat("Vanamo Lindholm", "Arkistokatu 91", new DateTime(1966,09,22)),
                new Opiskelijat("Kuisma Vuorinen", "Hanhikankaankatu 29", new DateTime(1988,01,01)),
                new Opiskelijat("Päivö Mäki", "Kokkomäenkatu 3", new DateTime(1992,12,02)),
                new Opiskelijat("Salla Laukkanen", "Laiturikatu 59", new DateTime(2000,11,09))
            };
            ////Define youngman's definition
            //DateTime youngman = DateTime.Parse("1.1.1970");
            //var realYoung = from item in opiskelijaryhma
            //                where item.DateOfBirth > youngman
            //                select item;
            ////let's see who is young
            //Console.WriteLine("These are youngman!");
            //Console.WriteLine();
            //foreach (var handsomeAndBeautiful in realYoung)

            //    Console.WriteLine(handsomeAndBeautiful);
            //Console.WriteLine();

            //var listByAlphabet = from item in opiskelijaryhma
            //                     orderby item.Name[0]
            //                     select item;

            //Console.WriteLine("These are listed name by alphabet!");
            //Console.WriteLine();
            //foreach (var whoKnows in listByAlphabet)
            //    Console.WriteLine(whoKnows);

            //var addressListing = from item in opiskelijaryhma
            //                     orderby item.Address[0]
            //                     select item;

            //Console.WriteLine("These are listed addresses by alphabet!");
            //Console.WriteLine();
            //foreach (var ohLetsTry in addressListing)
            //    Console.WriteLine(ohLetsTry);


            //Console.ReadLine();

            var onlyHaveKuja = from item in opiskelijaryhma
                               where item.Address.Contains("kuja")
                               select item;

            Console.WriteLine("These are addresses have letter -kuja!");
            Console.WriteLine();
            foreach (var ohLetsTry2 in onlyHaveKuja)
                Console.WriteLine(ohLetsTry2);
            //var 地址排列 = from item in opiskelijaryhma
            //              orderby item.Address.Sort()
            //              select item;

            //Console.WriteLine("These are addresses listed by its number!");
            //Console.WriteLine();
            //foreach (var ohLetsTry3 in 地址排列)
            //    Console.WriteLine(ohLetsTry3);


            Console.ReadLine();
        }
    }
}
