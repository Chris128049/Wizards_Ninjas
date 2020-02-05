   public class Human
{
    // Fields for Human
    public string Name{get;set;}
    public int Strength{get;set;} = 5;
    public int Intelligence{get;set;} = 5;
    public int Dexterity{get;set;} = 5;
    private int health{get;set;} = 100;

     public int Health  
        {
            set { health = value;}  // this is required when the property is private (to modify as a default in children classes)
                                    // otherwise, defaults can be modified as with the other properties (Strength, Intel, Dexterity)
            get { return health;}   // add a public "getter" property to access health

        }



   public Human(string name)  
        {
            Name = name;
        }

        
            



    public Human(string Name, int Strength, int Intelligence, int Dexterity, int health){
        this.Name = Name;
        this.Strength = Strength;
        this.Intelligence = Intelligence;
        this.Dexterity = Dexterity;
        this.health = health;
    }
  

     public virtual void Attack(Human victim) // Build Attack method
        {
            var Victim =  (Human) victim;
            Victim.health -= 2 * Strength;
            // Console.ForegroundColor = ConsoleColor.Red;
            // Console.WriteLine($"ATTACK! {Victim.Name} loses {2 * Strength} pts from their Health!");
            // Console.WriteLine("Current Victim Stats: " + Victim.ToString() );
            // Console.ForegroundColor = ConsoleColor.White;
        }



public override string ToString()
        {
            string str;
            str = string.Format("{0}, Here are your attributes for: Strenght {1}, Intelligence {2} Dexterity: {3}, Health {4},", Name, Strength, Intelligence,  Dexterity, Health);
            // str = $"Human Name: {Name}, Strenght: {Strength} Intelligence: {Intelligence} Dexterity: {Dexterity} Health: {health}";
            return str;
        }

}