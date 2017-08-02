namespace Jarvis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Arm
    {
        public int EnergyConsumption { get; set; }
        public int ReachDistance { get; set; }
        public int FingersCount { get; set; }
    }

    public class Leg
    {
        public int EnergyConsumption { get; set; }
        public int Strenght { get; set; }
        public int Speed { get; set; }
    }

    public class Torso
    {
        public int EnergyConsumption { get; set; }
        public double ProcessorSize { get; set; }
        public string HousingMaterial { get; set; }
    }

    public class Head
    {
        public int EnergyConsumption { get; set; }
        public int IQ { get; set; }
        public string SkinMaterial { get; set; }
    }
    public class Robot
    {

        public List<Head> JarvisHead { get; set; }

        public List<Torso> JarvisTorso { get; set; }

        public List<Arm> JarvisArms { get; set; }

        public List<Leg> JarvsiLegs { get; set; }
    }

    public class Jarvis
    {
        public static void Main()
        {
            var maxEnergyCapacity = long.Parse(Console.ReadLine());
            var jarvis = new Robot();
            jarvis.JarvisArms = new List<Arm>();
            jarvis.JarvsiLegs = new List<Leg>();
            jarvis.JarvisHead = new List<Head>();
            jarvis.JarvisTorso = new List<Torso>();

            var line = Console.ReadLine();
            while (line != "Assemble!")
            {
                var tokens = line.Split();
                if (tokens[0] == "Head")
                {
                    if (jarvis.JarvisHead.Count < 1)
                    {
                        var head = new Head
                        {
                            EnergyConsumption = int.Parse(tokens[1]),
                            IQ = int.Parse(tokens[2]),
                            SkinMaterial = tokens[3]
                        };
                        jarvis.JarvisHead.Add(head);
                    }
                    else
                    {
                        if (jarvis.JarvisHead.First().EnergyConsumption > int.Parse(tokens[1]))
                        {
                            jarvis.JarvisHead.First().EnergyConsumption = int.Parse(tokens[1]);
                            jarvis.JarvisHead.First().IQ = int.Parse(tokens[2]);
                            jarvis.JarvisHead.First().SkinMaterial = tokens[3];
                        }
                    }

                }
                else if (tokens[0] == "Torso")
                {
                    if (jarvis.JarvisTorso.Count < 1)
                    {
                        var torso = new Torso
                        {
                            EnergyConsumption = int.Parse(tokens[1]),
                            ProcessorSize = double.Parse(tokens[2]),
                            HousingMaterial = tokens[3]
                        };
                        jarvis.JarvisTorso.Add(torso);
                    }
                    else
                    {
                        if (jarvis.JarvisTorso.First().EnergyConsumption > int.Parse(tokens[1]))
                        {
                            jarvis.JarvisTorso.First().EnergyConsumption = int.Parse(tokens[1]);
                            jarvis.JarvisTorso.First().ProcessorSize = double.Parse(tokens[2]);
                            jarvis.JarvisTorso.First().HousingMaterial = tokens[3];
                        }
                    }
                }
                else if (tokens[0] == "Leg")
                {
                    if (jarvis.JarvsiLegs.Count < 2)
                    {
                        var leg = new Leg
                        {
                            EnergyConsumption = int.Parse(tokens[1]),
                            Strenght = int.Parse(tokens[2]),
                            Speed = int.Parse(tokens[3])
                        };

                        jarvis.JarvsiLegs.Add(leg);
                    }
                    else
                    {
                        if (jarvis.JarvsiLegs.First().EnergyConsumption > int.Parse(tokens[1]) && jarvis.JarvsiLegs[1].EnergyConsumption > int.Parse(tokens[1]))
                        {
                            jarvis.JarvsiLegs.First().EnergyConsumption = int.Parse(tokens[1]);
                            jarvis.JarvsiLegs.First().Strenght = int.Parse(tokens[2]);
                            jarvis.JarvsiLegs.First().Speed = int.Parse(tokens[3]);
                        }
                    }

                }
                else if (tokens[0] == "Arm")
                {
                    if (jarvis.JarvisArms.Count < 2)
                    {
                        var arm = new Arm
                        {
                            EnergyConsumption = int.Parse(tokens[1]),
                            ReachDistance = int.Parse(tokens[2]),
                            FingersCount = int.Parse(tokens[3])
                        };

                        jarvis.JarvisArms.Add(arm);
                    }
                    else
                    {
                        if (jarvis.JarvisArms.First().EnergyConsumption > int.Parse(tokens[1]) && jarvis.JarvisArms[1].EnergyConsumption > int.Parse(tokens[1]))
                        {
                            jarvis.JarvisArms.First().EnergyConsumption = int.Parse(tokens[1]);
                            jarvis.JarvisArms.First().ReachDistance = int.Parse(tokens[2]);
                            jarvis.JarvisArms.First().FingersCount = int.Parse(tokens[3]);
                        }
                    }
                }

                line = Console.ReadLine();
            }
            if ((jarvis.JarvisArms.Count == 2) && jarvis.JarvsiLegs.Count == 2 && jarvis.JarvisHead.Count == 1 && jarvis.JarvisTorso.Count == 1)
            {
                long totalConsumption = jarvis.JarvisHead.First().EnergyConsumption +
                jarvis.JarvisTorso.First().EnergyConsumption +
                 jarvis.JarvisArms.First().EnergyConsumption +
                  jarvis.JarvisArms[1].EnergyConsumption +
                     jarvis.JarvsiLegs.First().EnergyConsumption +
                         jarvis.JarvsiLegs[1].EnergyConsumption;
                if (totalConsumption > maxEnergyCapacity)
                {
                    Console.WriteLine("We need more power!");
                }
                else
                {
                    Console.WriteLine("Jarvis:");
                    Console.WriteLine("#Head:");
                    Console.WriteLine($"###Energy consumption: {jarvis.JarvisHead.First().EnergyConsumption}");
                    Console.WriteLine($"###IQ: {jarvis.JarvisHead.First().IQ}");
                    Console.WriteLine($"###Skin material: {jarvis.JarvisHead.First().SkinMaterial}");
                    Console.WriteLine("#Torso:");
                    Console.WriteLine($"###Energy consumption: {jarvis.JarvisTorso.First().EnergyConsumption}");
                    Console.WriteLine($"###Processor size: {jarvis.JarvisTorso.First().ProcessorSize:F1}");
                    Console.WriteLine($"###Corpus material: {jarvis.JarvisTorso.First().HousingMaterial}");
                    foreach (var arm in jarvis.JarvisArms.OrderBy(x=>x.EnergyConsumption))
                    {
                        Console.WriteLine("#Arm:");
                        Console.WriteLine($"###Energy consumption: {arm.EnergyConsumption}");
                        Console.WriteLine($"###Reach: {arm.ReachDistance}");
                        Console.WriteLine($"###Fingers: {arm.FingersCount}");
                    }
                    foreach (var leg in jarvis.JarvsiLegs.OrderBy(x=>x.EnergyConsumption))
                    {
                        Console.WriteLine("#Leg:");
                        Console.WriteLine($"###Energy consumption: {leg.EnergyConsumption}");
                        Console.WriteLine($"###Strength: {leg.Strenght}");
                        Console.WriteLine($"###Speed: {leg.Speed}");
                    }
                }
            }
            else
            {
                Console.WriteLine("We need more parts!");
            }
        }
    }
}
