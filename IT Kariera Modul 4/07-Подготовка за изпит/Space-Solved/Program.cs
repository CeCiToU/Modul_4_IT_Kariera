using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp333
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Galaxy> galaxies = new List<Galaxy>();
            List<Star> stars = new List<Star>();
            List<Planet> planets = new List<Planet>();
            List<Moon> moons = new List<Moon>();

            char[] firstCommand = Console.ReadLine().ToCharArray();
            string[] command = Split(firstCommand);
            while (command[0] != "exit")
            {
                if (command.Length <= 5 || command.Length == 8)
                {
                    switch (command[0])
                    {
                        case "add":
                            switch (command[1])
                            {
                                case "galaxy":
                                    Galaxy currentGalaxy = new Galaxy(command[2], command[3], command[4]);
                                    galaxies.Add(currentGalaxy);
                                    break;
                                case "star":
                                    Star currentStar = new Star(command[2], command[3], double.Parse(command[4]), double.Parse(command[5]), int.Parse(command[6]), double.Parse(command[7]));
                                    string classSet = currentStar.StarClassSet();
                                    currentStar.StarClass = classSet;
                                    stars.Add(currentStar);
                                    break;
                                case "planet":
                                    Planet currentPlanet = new Planet(command[2], command[3], command[4], command[5]);
                                    planets.Add(currentPlanet);
                                    break;
                                case "moon":
                                    Moon currentMoon = new Moon(command[2], command[3]);
                                    moons.Add(currentMoon);
                                    break;
                            }
                            break;
                        case "list":
                            ListPrint(galaxies);
                            break;
                        case "stats":
                            Stats(galaxies.Count, stars.Count, planets.Count, moons.Count);
                            break;
                        case "print":
                            int num = 0;
                            for (int i = 0; i < galaxies.Count; i++)
                            {
                                if (galaxies[i].Name == command[1])
                                {
                                    num = i;
                                    break;
                                }
                            }
                            Console.WriteLine($"--- Data for {command[1]} galaxy ---");
                            Console.WriteLine($"Type: {galaxies[num].Type}");
                            Console.WriteLine($"Age: {galaxies[num].Age} \nStars:\n");
                            for (int o = 0; o < stars.Count; o++)
                            {
                                if (stars[o].GalaxyName == command[1] + " " + command[2])
                                {
                                    Console.WriteLine($"   -    Name:{stars[o].StarName}");
                                    Console.WriteLine($"        Class: {stars[o].StarClass}({stars[o].Weight:F2}, {stars[o].Size:F2}, {stars[o].Temperature}, {stars[o].Compatibility:F2})");
                                    Console.WriteLine($"        Planets:");
                                    for (int j = 0; j < planets.Count; j++)
                                    {
                                        if (planets[j].StarName == stars[o].StarName)
                                        {
                                            Console.WriteLine($"             o Name:{planets[j].PlanetName}");
                                            Console.WriteLine($"               Type:{planets[j].PlanetType}");
                                            Console.WriteLine($"               Suppurt life:{planets[j].SupportLife}\n               Moons:");
                                            for (int p = 0; p < moons.Count; p++)
                                            {
                                                if(moons)
                                                if (moons[p].PlanetName == planets[j].PlanetName)
                                                {
                                                    Console.WriteLine($"                   {moons[p].MoonName}");
                                                }
                                            }
                                        }


                                    }
                                }
                            }
                            Console.WriteLine($"--- End of data for {command[1]} galaxy");
                            
                            break;
                    }
                }
                else if (command.Length == 6 || command.Length == 9)
                {
                        switch (command[0])
                        {
                            case "add":
                            switch (command[1])
                            {
                                case "galaxy":
                                    Galaxy currentGalaxy = new Galaxy(command[2] + " " + command[3], command[4], command[5]);
                                    galaxies.Add(currentGalaxy);
                                    break;
                                case "star":
                                    Star currentStar = new Star(command[2] + " " + command[3], command[4], double.Parse(command[5]), double.Parse(command[6]), int.Parse(command[7]), double.Parse(command[8]));
                                    string classSet = currentStar.StarClassSet();
                                    currentStar.StarClass = classSet;
                                    stars.Add(currentStar);
                                        break;
                                    case "planet":
                                    Planet currentPlanet = new Planet(command[2], command[3], command[4], command[5]);
                                    planets.Add(currentPlanet);
                                    break;
                                    case "moon":
                                        Moon currentMoon = new Moon(command[2], command[3]);
                                        moons.Add(currentMoon);
                                        break;
                                }
                                break;
                            case "list":
                                ListPrint(galaxies);
                                break;
                            case "stats":
                                Stats(galaxies.Count, stars.Count, planets.Count, moons.Count);
                                break;
                            case "print":
                            int num = 0;
                            for (int i = 0; i < galaxies.Count; i++)
                            {
                                if (galaxies[i].Name == command[1])
                                {
                                    num = i;
                                    break;
                                }
                            }
                            for (int i = 0; i < galaxies.Count; i++)
                                {
                                    if (galaxies[i].Name == command[1])
                                    {
                                    Console.WriteLine($"--- Data for {command[1]} {command[2]} galaxy ---");
                                    Console.WriteLine($"Type: {galaxies[num].Type}");
                                    Console.WriteLine($"Age: {galaxies[num].Age} \nStars:\n");
                                    for (int o = 0; o < stars.Count; o++)
                                    {
                                        if (stars[o].GalaxyName == command[1])
                                        {
                                            Console.WriteLine($"   -    Name:{stars[o].StarName}");
                                            Console.WriteLine($"        Class: {stars[o].StarClass}({stars[o].Weight:F2}, {stars[o].Size:F2}, {stars[o].Temperature}, {stars[o].Compatibility:F2})");
                                            Console.WriteLine($"        Planets:");
                                            for (int j = 0; j < planets.Count; j++)
                                            {
                                                if (planets[j].StarName == stars[o].StarName)
                                                {
                                                    Console.WriteLine($"             o Name:{planets[j].PlanetName}");
                                                    Console.WriteLine($"               Type:{planets[j].PlanetType}");
                                                    Console.WriteLine($"               Suppurt life:{planets[j].SupportLife}\n               Moons:");
                                                    for (int p = 0; p < moons.Count; p++)
                                                    {
                                                        if (moons[p].PlanetName == planets[j].PlanetName)
                                                        {
                                                            Console.WriteLine($"               Suppurt life:{planets[j].SupportLife}");
                                                            Console.WriteLine($"                   {moons[p].MoonName}");
                                                        }
                                                    }
                                                }


                                            }
                                        }
                                    }
                                    Console.WriteLine($"--- End of data for {command[1]} {command[2]} galaxy");
                                }
                                }
                                break;
                        }
                }

                firstCommand = Console.ReadLine().ToCharArray();
                command = Split(firstCommand);
            }

        }

        private static void Print(Galaxy galaxy, Star star, Planet planet, Moon moon)
        {
            
        }

        private static string[] Split(char[] str)
        {
            List<string> str2 = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str2.Count <= 0)
                {
                    str2.Add(str[i].ToString());
                }
                else if (str[i] == ' ')
                {
                    if (str[i + 1] == '[')
                    {
                        str2.Add(str[i + 2].ToString());
                        i += 2;
                    }
                    else
                    {
                        str2.Add(str[i + 1].ToString());
                        i++;
                    }

                }
                else if (str[i] == '[')
                {
                    str2.Add(str[i + 1].ToString());
                    i++;
                }
                else if (str[i] == ']')
                {
                    try
                    {
                        if (str[i + 1] == ' ')
                        {
                            if (str[i + 2] == '[')
                            {
                                str2.Add(str[i + 3].ToString());
                                i += 3;
                            }
                            else
                            {
                                str2.Add(str[i + 2].ToString());
                                i += 2;
                            }
                        }
                        else
                        {
                            str2.Add(str[i + 1].ToString());
                            i++;
                        }
                    }
                    catch
                    {

                    }
                }
                else
                {
                    str2[str2.Count - 1] += str[i];
                }
            }
            return str2.ToArray();
        }

        private static void Stats(int galaxies, int stars, int planets, int moons)
        {
            Console.WriteLine("--- Stats ---");
            Console.WriteLine($"Galaxies: {galaxies}");
            Console.WriteLine($"Stars: {stars}");
            Console.WriteLine($"Planets: {planets}");
            Console.WriteLine($"Moons: {moons}");
            Console.WriteLine($"--- End of stats ---");
        }

        private static void ListPrint(List<Galaxy> galaxies)
        {
            Console.WriteLine("--- List of all researched galaxies ---");
            foreach (var galaxy in galaxies)
            {
                Console.WriteLine(galaxy.Name);
            }
            Console.WriteLine("--- End of galaxies list ---");
        }
    }
}
