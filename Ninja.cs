    
    using System;
    public class Ninja : Human
    {
        public Ninja(string name) :base(name)
        {
            Dexterity = 175;
        }
        public void Steal(Human victim)
        {
            victim.Health -= 10;
            Health += 10;
        }
        public override void Attack(Human victim) // Build Override Attack method for Ninja
        {
            var Victim = (Human) victim;
            Victim.Health -= 5 * Dexterity;
            Random rand = new Random();
            int idx = rand.Next(1,11);
            if (idx < 3)
            {
                Victim.Health -= 10;
                Console.ForegroundColor = ConsoleColor.Red;  
                Console.WriteLine("Bonus Attack Successful!");  
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ATTACK! {Victim.Name} loses {2 * Dexterity} pts from their Health!");
            Console.WriteLine("Current Victim Stats: " + Victim.ToString() );
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }