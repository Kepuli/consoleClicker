using ConsoleClikker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("COOKIE CLIKKER");
            Console.WriteLine("--------------------------------------");
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


            Tilanne tilanne = new Tilanne();
            do {
                string kirj = Console.ReadLine();
                if (kirj == "grandmama") {
                    if (tilanne.GrandmamaSallittu) {
                        Console.WriteLine("sinulla on nyt yksi uusi grandmama");
                        tilanne.korotus++;
                        tilanne.x = tilanne.x - 100;
                        tilanne.y = tilanne.y + 1;
                    } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä");
                }
                if (kirj == "farm") {
                    if (tilanne.x >= 500) {
                        Console.WriteLine("sinulla on nyt yksi uusi farmi");
                        tilanne.korotus = tilanne.korotus + 6;
                        tilanne.x = tilanne.x - 500;
                        tilanne.y = tilanne.y + 1;
                    } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä");
                }
                if (kirj == "factory") {
                    if (tilanne.x >= 50000) {
                        Console.WriteLine("sinulla on uusi factory!");
                        tilanne.korotus = tilanne.korotus + 50;
                        tilanne.x = tilanne.x - 100000;
                        tilanne.y = tilanne.y + 1;
                    } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä");
                }
                if (kirj == "redmatter condenser") {
                    if (tilanne.x >= 700000) {
                        Console.WriteLine("sinulla on uusi redmatter condenser!");
                        tilanne.korotus = tilanne.korotus + tilanne.x2;
                        tilanne.x = tilanne.x - 700000;
                        tilanne.y = tilanne.y + 1;
                    } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä");
                }
                if (kirj == "darkmatter condenser") {
                    if (tilanne.x >= 10000000) {
                        Console.WriteLine("sinulla on uusi Darkmatter condenser!");
                        tilanne.korotus = tilanne.korotus + 900;
                        tilanne.x = tilanne.x - 10000000;
                        tilanne.y = tilanne.y + 1;
                    } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä");
                }
                if (kirj == "mother cookie") {
                    if (tilanne.x >= 50000000) {
                        Console.WriteLine("sinulla on uusi mother cookie!");
                        tilanne.korotus = tilanne.korotus + 6000;
                        tilanne.x = tilanne.x - 5000000;
                        tilanne.y = tilanne.y + 1;
                    } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä");
                }

                if (kirj == "god") {
                    if (tilanne.x >= 100000000) {
                        Console.WriteLine("sinulla on COOKIE GOD!");
                        tilanne.korotus = tilanne.korotus + 15000;
                        tilanne.x = tilanne.x - 100000000;
                        tilanne.y = tilanne.y + 1;
                    } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä");
                }
                if (kirj == "minor upgrade") {
                    if (tilanne.x >= 20000) {
                        if (tilanne.z <= 10) {
                            Console.WriteLine("sinun ostokset tuottavat nyt 1 enemmän kuin ennen");
                            tilanne.korotus = tilanne.korotus + tilanne.y;
                            tilanne.x = tilanne.x - 20000;
                            tilanne.z = tilanne.z + 10;
                        } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä tai olet jo ostanut tämän päivityksen");
                    }
                }
                if (kirj == "major upgrade") {
                    if (tilanne.x >= 200000) {
                        if (tilanne.z <= 20) {
                            Console.WriteLine("sinun ostokset tuottavat nyt 8 enemmän kuin ennen");
                            tilanne.korotus = tilanne.korotus + 8 * tilanne.y;
                            tilanne.x = tilanne.x - 200000;
                            tilanne.z = tilanne.z + 10;
                        } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä tai olet jo ostanut tämän päivityksen");
                    }
                }
                if (kirj == "the red redmatter") {
                    if (tilanne.x >= 30000000) {
                        if (tilanne.z2 <= 10) {
                            Console.WriteLine("tästä eteenpäin jokainen redmatter condenser tuottaa 100 enemmäm");
                            tilanne.x2 = tilanne.x2 + 100;
                            tilanne.x = tilanne.x - 30000000;
                            tilanne.z2 = tilanne.z2 + 10;
                        } else Console.WriteLine("sinulla ei ole tarpeeksi keksejä tai olet jo ostanut tämän päivityksen");
                    }
                }
                if (kirj == "butter is better") {
                    if (tilanne.x >= 600000000) {
                        if (tilanne.butterKaytetty)
                            Console.WriteLine("sinulla ei ole tarpeeksi keksejä tai olet jo ostanut tämän päivityksen");
                        else {
                            Console.WriteLine("sinun tämän hetkinen per click on tuplaantunut");
                            tilanne.korotus = tilanne.korotus + tilanne.korotus;
                            tilanne.x = tilanne.x - 600000000;
                            tilanne.butterKaytetty = true;
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
                    tilanne.x = tilanne.x + 100000000;
                }
                if (kirj == "/restart") {
                    tilanne.Restart();
                }
                tilanne.x = tilanne.x + tilanne.korotus;
                Console.WriteLine("cookie " + tilanne.x.ToString());
            } while (true);





        }
    }
}
