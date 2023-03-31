using System;
namespace s2l4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier[] soldiers = new Soldier[]
            {
                new Soldier("John Smith", "Thunder", "Infantry", "Sergeant", "AK-47"),
                new Soldier("Mike Johnson", "Pony", "Medic", "Corporal", "M16"),
                new Soldier("Bob Brown", "Thunder", "Sniper", "Sergeant", "M24"),
                new Soldier("David Lee", "Thunder", "Medic", "Sergeant", "M24"),
                new Soldier("William Chen", "Pony", "Sniper", "Sergeant", "M24"),
                new Soldier("Thomas Wang", "Pony", "Sniper", "Sergeant", "M24"),
                new Soldier("James Kim", "Thunder", "Cook", "Sergeant", "M16"),
                new Soldier("Jacob Lee", "Pony", "Infantry", "Private", "AK-47"),
                new Soldier("Andrew Park", "Thunder", "Medic", "Corporal", "M16"),
                new Soldier("Eric Kim", "Pony", "Sniper", "Sergeant", "M24"),
                new Soldier("Brandon Lee", "Pony", "Infantry", "Corporal", "AK-47"),
                new Soldier("Michelle Lee", "Pony", "Medic", "Sergeant", "M16"),
                new Soldier("Linda Lee", "Thunder", "Cook", "Corporal", "AK-47"),
                new Soldier("Sarah Kim", "Pony", "Sniper", "Corporal", "M24"),
                new Soldier("Emily Lee", "Thunder", "Infantry", "Private", "AK-47")
            };
            while (true)
            {
                Console.WriteLine("Enter 0 to sort by specialisation, 1 to check the same weapon, 2 to search by squad and 3 to leave.");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Eel();
                        break;
                    case "0":
                        Console.Clear();
                        Catfish();
                        break;
                    case "2":
                        Console.Clear();
                        Whale();
                        break;
                    case "3":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            void Whale()
            {
                Console.WriteLine("Name of the squad:");
                string squad = Console.ReadLine();
                var squadofsoldiers = soldiers.Where(s => s.squad == squad);

                if (squadofsoldiers.Count() > 0)
                {
                    Console.WriteLine($"Soldiers in {squad}:");
                    foreach (var soldier in squadofsoldiers)
                    {
                        Console.WriteLine($"{soldier.name} - {soldier.specialisation} - {soldier.rank}");
                    }
                }
                else if (squadofsoldiers.Count() == 0)
                {
                    Console.WriteLine($"No soldiers in squad {squad}.");
                }
            }
            void Catfish()
            {
                var soldiersBySpecialisation = soldiers.OrderBy(s => s.specialisation);
                foreach (var soldier in soldiersBySpecialisation)
                {
                    Console.WriteLine($"{soldier.specialisation} - {soldier.name}");
                }
            }

            void Eel()
            {
                Console.WriteLine("Name of the weapon:");
                string weapon = Console.ReadLine();
                var soldiersWithSameWeapon = soldiers.Where(s => s.weapon == weapon);

                if (soldiersWithSameWeapon.Count() >= 2)
                {
                    Console.WriteLine($"Soldiers with weapon {weapon}:");
                    foreach (var soldier in soldiersWithSameWeapon)
                    {
                        Console.WriteLine($"{soldier.name} - {soldier.specialisation} - {soldier.rank}");
                    }
                }
                else if (soldiersWithSameWeapon.Count() == 1)
                {
                    Console.WriteLine($"Only one soldier with {weapon}.");
                }
                else
                {
                    Console.WriteLine($"No soldiers with {weapon}.");
                }
            }

        }
    }
        class Soldier
        {
            public string name;
            public string squad;
            public string specialisation;
            public string rank;
            public string weapon;
            public Soldier(string _name, string _squad, string _specialisation, string _rank, string _weapon)
            {
                name = _name;
                squad = _squad;
                specialisation = _specialisation;
                rank = _rank;
                weapon = _weapon;
            }
        }
}