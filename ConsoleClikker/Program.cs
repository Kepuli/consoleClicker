using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("COOKIE CLIKKER");
            Console.WriteLine();
            Console.WriteLine("grandmama maksaa 100");
            Console.WriteLine("farmi maksaa 500");
            Console.WriteLine("minor upgrade maksaa 20.000");
            Console.WriteLine("factory maksaa 50.000");
            Console.WriteLine("major upgrade maksaa 200.000");
            Console.WriteLine("redmatter condenser maksaa 700.000");
            Console.WriteLine("Darkmatter condenser maksaa 10.000.000");
            Console.WriteLine("the red redmatter (upgrade) maksaa 30.000.000");
            Console.WriteLine("mother cookie maksaa 50.000");
            Console.WriteLine("COOKIE GOD maksaa 100.000.000");
            Console.WriteLine();
            Console.WriteLine("NEW UPDATE test now!");
            Console.WriteLine();
            int z2 = 5;
            int x2 = 200;
            int z = 5;
            int x = 0;
            int y = 0;
            int korotus = 1;
            bool butterKaytetty = false;
            do {
                string kirj = Console.ReadLine();
                if (kirj == "grandmama") {
                    if (x >= 100) {
                        Console.WriteLine("sinulla on nyt yksi uusi grandmama");
                        korotus++;
                        x = x - 100;
                        y = y + 1;
                    } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä");
                }
                if (kirj == "farm") {
                    if (x >= 500) {
                        Console.WriteLine("sinulla on nyt yksi uusi farmi");
                        korotus = korotus + 6;
                        x = x - 500;
                        y = y + 1;
                    } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä");
                }
                if (kirj == "factory") {
                    if (x >= 50000) {
                        Console.WriteLine("sinulla on uusi factory!");
                        korotus = korotus + 50;
                        x = x - 100000;
                        y = y + 1;
                    } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä");
                }
                if (kirj == "redmatter condenser") {
                    if (x >= 700000) {
                        Console.WriteLine("sinulla on uusi redmatter condenser!");
                        korotus = korotus + x2;
                        x = x - 700000;
                        y = y + 1;
                    } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä");
                }
                if (kirj == "darkmatter condenser") {
                    if (x >= 10000000) {
                        Console.WriteLine("sinulla on uusi Darkmatter condenser!");
                        korotus = korotus + 900;
                        x = x - 10000000;
                        y = y + 1;
                    } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä");
                }
                if (kirj == "mother cookie") {
                    if (x >= 50000000) {
                        Console.WriteLine("sinulla on uusi mother cookie!");
                        korotus = korotus + 6000;
                        x = x - 5000000;
                        y = y + 1;
                    } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä");
                }

                if (kirj == "god") {
                    if (x >= 100000000) {
                        Console.WriteLine("sinulla on COOKIE GOD!");
                        korotus = korotus + 15000;
                        x = x - 100000000;
                        y = y + 1;
                    } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä");
                }
                if (kirj == "minor upgrade") {
                    if (x >= 20000) {
                        if (z <= 10) {
                            Console.WriteLine("sinun ostokset tuottavat nyt 1 enemmän kuin ennen");
                            korotus = korotus + y;
                            x = x - 20000;
                            z = z + 10;
                        } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä tai olet jo ostanut tämän päivityksen");
                    }
                }
                if (kirj == "major upgrade") {
                    if (x >= 200000) {
                        if (z <= 20) {
                            Console.WriteLine("sinun ostokset tuottavat nyt 8 enemmän kuin ennen");
                            korotus = korotus + 8 * y;
                            x = x - 200000;
                            z = z + 10;
                        } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä tai olet jo ostanut tämän päivityksen");
                    }
                }
                if (kirj == "the red redmatter") {
                    if (x >= 30000000) {
                        if (z2 <= 10) {
                            Console.WriteLine("tästä eteenpäin jokainen redmatter condenser tuottaa 100 enemmäm");
                            x2 = x2 + 100;
                            x = x - 30000000;
                            z2 = z2 + 10;
                        } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä tai olet jo ostanut tämän päivityksen");
                    }
                }
                if (kirj == "butter is better") {
                    if (x >= 600000000) {
                        if (butterKaytetty)
                            Console.WriteLine("sinulla ei ole tarpeeksi keksejä tai olet jo ostanut tämän päivityksen");
                        else {
                            Console.WriteLine("sinun tämän hetkinen per click on tuplaantunut");
                            korotus = korotus + korotus;
                            x = x - 600000000;
                            butterKaytetty = true;
                        }
                    }
                }

                if (kirj == "prices") {
                    Console.WriteLine("grandmama maksaa 100");
                    Console.WriteLine("farmi maksaa 500");
                    Console.WriteLine("minor upgrade maksaa 20.000");
                    Console.WriteLine("factory maksaa 50.000");
                    Console.WriteLine("major upgrade maksaa 200.000");
                    Console.WriteLine("redmatter condenser maksaa 700.000");
                    Console.WriteLine("Darkmatter condenser maksaa 10.000.000");
                    Console.WriteLine("the red redmatter (upgrade) maksaa 30.000.000");
                    Console.WriteLine("mother cookie maksaa 50.000");
                    Console.WriteLine("COOKIE GOD maksaa 100.000.000");
                }
                if (kirj == "/give 100 000 000 cookies") {
                    x = x + 100000000;
                }
                if (kirj == "/restart") {
                    x = 0;
                    z = 0;
                    y = 0;
                    x2 = 200;
                    z2 = 5;
                    butterKaytetty = false;
                    korotus = 1;
                }
                x = x + korotus;
                Console.WriteLine("cookie " + x.ToString());
            } while (true);





        }
    }
}
