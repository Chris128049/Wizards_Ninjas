 public class Wizard : Human
    {
        public Wizard(string name) :base(name)
        {
            Health = 50;
            Intelligence = 25;
        }
        public void Heal(Human victim)
        {
            victim.Health += 10*victim.Intelligence;
        }
    }