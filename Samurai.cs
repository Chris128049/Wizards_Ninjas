    using System;
    
    
    public class Samurai : Human
    {
        public Samurai(string name) :base(name)
        {
            Health = 200; // from public int Health in Human Class
        }

        public void Meditate()
        {
            Health = 200;
        }
        public override void Attack(Human victim) // Build Override Attack method for Samurai
        {
            var Victim = (Human) victim;
            if (Victim.Health < 50)
            {
                Victim.Health = 0;  
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bonus Attack Successful!; Health Reduced to Zero!");  
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ATTACK! {Victim.Name} loses {2 * Dexterity} pts from their Health!");
            Console.WriteLine("Current Victim Stats: " + Victim.ToString() );
            Console.ForegroundColor = ConsoleColor.White;
        }
    }