using System;
using System.Collections.Generic;
using System.Linq;
namespace Flyweight_28._03._2023
{
    class Program
    {
        public abstract class Combat_Unit
        {
            public string Picture_display { set; get; }
            public int Movement_speed { set; get; }
            public double Force_factor { set; get; }

            public abstract void Show(double x, double y);
        }
        public class Pehota: Combat_Unit
        {
            public Pehota()
            {
                Picture_display = "Поле";
                Movement_speed = 20;
                Force_factor = 10;
            }
            public override void Show(double x, double y)
            {
                Console.WriteLine($"Пехота имеет координаты ---> {x}\t{y}");
                Console.WriteLine($"Picture_display_Pehota:{Picture_display}\nMovement_speed_Pehota:{Movement_speed}\nForce_factor_Pehota:{Force_factor}\n");
            }
        }
        public class Auto_Car : Combat_Unit
        {
            public Auto_Car()
            {
                Picture_display = "Дорога";
                Movement_speed = 70;
                Force_factor = 0;
            }
            public override void Show(double x, double y)
            {
                Console.WriteLine($"Авто имеет координаты ---> {x}\t{y}");
                Console.WriteLine($"Picture_display_Pehota:{Picture_display}\nMovement_speed_Pehota:{Movement_speed}\nForce_factor_Pehota:{Force_factor}\n");
            }
        }
        public class Heavy_ground_combat_equipment : Combat_Unit
        {
            public Heavy_ground_combat_equipment()
            {
                Picture_display = "Поле";
                Movement_speed = 15;
                Force_factor = 150;
            }
            public override void Show(double x, double y)
            {
                Console.WriteLine($"Тяжолая техника имеет координаты ---> {x}\t{y}");
                Console.WriteLine($"Picture_display_Pehota:{Picture_display}\nMovement_speed_Pehota:{Movement_speed}\nForce_factor_Pehota:{Force_factor}\n");
            }
        }
        public class Light_ground_combat_equipment : Combat_Unit
        {
            public Light_ground_combat_equipment()
            {
                Picture_display = "Поле";
                Movement_speed = 50;
                Force_factor = 30;
            }
            public override void Show(double x, double y)
            {
                Console.WriteLine($"Легкая техника имеет координаты ---> {x}\t{y}");
                Console.WriteLine($"Picture_display_Pehota:{Picture_display}\nMovement_speed_Pehota:{Movement_speed}\nForce_factor_Pehota:{Force_factor}\n");
            }
        }
        public class Aircraft : Combat_Unit
        {
            public Aircraft()
            {
                Picture_display = "Небо";
                Movement_speed = 300;
                Force_factor = 100;
            }
            public override void Show(double x, double y)
            {
                Console.WriteLine($"Воздушные силы имееют координаты ---> {x}\t{y}");
                Console.WriteLine($"Picture_display_Pehota:{Picture_display}\nMovement_speed_Pehota:{Movement_speed}\nForce_factor_Pehota:{Force_factor}\n");
            }
        }
        public class FlyweightFactory
        {
            
            Dictionary<string, Combat_Unit> keys = new Dictionary<string, Combat_Unit>();

            public FlyweightFactory()
            {
                keys.Add("Pehota", new Pehota());
                keys.Add("Auto",new Auto_Car());
                keys.Add("Тяжелая техника", new Heavy_ground_combat_equipment());
                keys.Add("Легкая техника",new Light_ground_combat_equipment());
                keys.Add("Авиация",new Aircraft());
            }
            public Combat_Unit GetCombat_Unit(string key)
            {
                if (!keys.ContainsKey(key))
                {
                    return keys[key];
                }
                if (keys.ContainsKey(key)==null)
                {
                    keys.Add("Pehota", new Pehota());
                    keys.Add("Auto", new Auto_Car());
                    keys.Add("Тяжелая техника", new Heavy_ground_combat_equipment());
                    keys.Add("Легкая техника", new Light_ground_combat_equipment());
                    keys.Add("Авиация", new Aircraft());
                }
                return null;
            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            FlyweightFactory flyweightFactory = new FlyweightFactory();
            Combat_Unit combat_Unit = flyweightFactory.GetCombat_Unit("Pehota");
            combat_Unit.Show(6.4, 5.6);
            Combat_Unit combat_Unit1 = flyweightFactory.GetCombat_Unit("Auto");
            combat_Unit1.Show(4.3,5.5);
            Combat_Unit combat_Unit2 = flyweightFactory.GetCombat_Unit("Тяжелая техника");
            combat_Unit2.Show(1.2,1.4);
            Combat_Unit combat_Unit3 = flyweightFactory.GetCombat_Unit("Легкая техника");
            combat_Unit3.Show(2.4,5);
            Combat_Unit combat_Unit4 = flyweightFactory.GetCombat_Unit("Авиация");
            combat_Unit4.Show(4,6.7);
            

        }
    }
}
