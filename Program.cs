using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wizards_ninja
{

class Program 
{

    
        static void Main(string[] args)
        {
            List<Human> allies = new List<Human>();
            string clan = "";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Player ONE Choose a Path from the following clans:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\ta - Human");
            Console.WriteLine("\tb - Wizard");
            Console.WriteLine("\tc - Ninja");
            Console.WriteLine("What path do you choose?");
            
             switch (Console.ReadLine())
             {
                case "a":
                clan = "Human";
                
                Console.WriteLine( "Enter Name:");
                string name = Console.ReadLine();
        
                Human hm1 = new Human(name);
                
                allies.Add(hm1);

                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{hm1} Your chosen path is: {clan}");
                break; 

                case "b":
                clan = "Wizard";
                Console.WriteLine( "Enter Name:");
                string name2 = Console.ReadLine();
        
                Wizard wz1 = new Wizard(name2);
                allies.Add(wz1);
                Console.WriteLine($"{wz1}Your chosen path is:{clan}");
                break;

                case "c":
                clan = "Ninja";
                Console.WriteLine( "Enter Name:");
                string name3 = Console.ReadLine();
        
                Ninja nj1 = new Ninja(name3);
                allies.Add(nj1);
                Console.WriteLine($"{nj1}Your chosen path is:{clan}");
                break;
            }

            
            string clan2 = "";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Player TWO choose a Path from the following clans:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\ta - Human");
            Console.WriteLine("\tb - Wizard");
            Console.WriteLine("\tc - Ninja");
            Console.WriteLine("What path do you choose?");
            
            switch (Console.ReadLine())
             {
                case "a":
                clan2 = "Human";
                // Console.WriteLine( "Enter up to 4 players:");
                Console.WriteLine( "Enter Name:");
                string name = Console.ReadLine();
        
                Human hm2 = new Human(name);
                allies.Add(hm2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{hm2} Your chosen path is: {clan2}");
                break; 

                 case "b":
                clan2 = "Wizard";
                Console.WriteLine( "Enter Name:");
                string name2 = Console.ReadLine();
                
                Wizard wz2 = new Wizard(name2);
                allies.Add(wz2);
                Console.WriteLine($"{wz2}Your chosen path is:{clan2}");
                break;

                case "c":
                clan2 = "Ninja";
                Console.WriteLine( "Enter Name:");
                string name3 = Console.ReadLine();
        
                Ninja nj2 = new Ninja(name3);
                allies.Add(nj2);
                Console.WriteLine($"{nj2}Your chosen path is:{clan2}");
                break;
            }

            string clan3 = "";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Player THREE Choose a Path from the following clans:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\ta - Human");
            Console.WriteLine("\tb - Wizard");
            Console.WriteLine("\tc - Ninja");
            Console.WriteLine("What path do you choose?");
            
            switch (Console.ReadLine())
              {
                case "a":
                clan3 = "Human";
                // Console.WriteLine( "Enter up to 4 players:");
                Console.WriteLine( "Enter Name:");
                string name = Console.ReadLine();
        
                Human hm3 = new Human(name);
                allies.Add(hm3);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{hm3} Your chosen path is: {clan3}");
                break; 

                 case "b":
                clan3 = "Wizard";
                Console.WriteLine( "Enter Name:");
                string name2 = Console.ReadLine();
        
                Wizard wz3 = new Wizard(name2);
                allies.Add(wz3);
                Console.WriteLine($"{wz3}Your chosen path is:{clan3}");
                break;

                case "c":
                clan3 = "Ninja";
                Console.WriteLine( "Enter Name:");
                string name3 = Console.ReadLine();
        
                Ninja nj3 = new Ninja(name3);
                allies.Add(nj3);
                Console.WriteLine($"{nj3}Your chosen path is:{clan3}");
                break;
            }

            while(allies.Count >= 0){

                //player 1-3 gets to attack other players and if this.player is dead remove him from list so he doesnt have a turn
                int currentPlayer = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Player {allies[currentPlayer].Name} Choose a Player to attack:");
                // foreach (Human allie in allies){
                    for(int i =0; i <allies.Count; i++){
                        if(currentPlayer != i){

                        // string clan = "";
                            
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"\t{i} - {allies[i].Name}");
                            
                        }
                        
                    
                    
            Console.WriteLine("who should you attack?");
            
             switch (Console.ReadLine())
             {
                case "1":
                
                allies[currentPlayer].Attack(allies[i]);

                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{allies[currentPlayer].Name} You attacked: {allies[i]}");
                currentPlayer += 1;
                break; 

                case "2":
                clan = "Wizard";
                Console.WriteLine( "Enter Name:");
                string name2 = Console.ReadLine();
        
                Wizard wz1 = new Wizard(name2);
                
                Console.WriteLine($"{wz1}Your chosen path is:{clan}");
                currentPlayer += 1;
                break;

            }
                    }
             
            }

        Console.ReadKey();
        }
    }
}
    


