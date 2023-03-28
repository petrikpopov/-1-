using System;

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
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Combat_Unit combat_Unit = new Pehota();
            combat_Unit.Show(4.4,1.4);
            /////////////////////////
            combat_Unit = new Auto_Car();
            combat_Unit.Show(3.1,9.3);
            /////////////////////////
            combat_Unit = new Heavy_ground_combat_equipment();
            combat_Unit.Show(4.3,1.3);
            /////////////////////////
            combat_Unit = new Light_ground_combat_equipment();
            combat_Unit.Show(6.5,5.5);
            /////////////////////////
            combat_Unit = new Aircraft();
            combat_Unit.Show(9.4, 2.6);
            /////////////////////////

        }
    }
}
