using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotographTheAdventuresBatdanAndRoben
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, weapon;
            int choice1, choice2, choice3;

            Console.WriteLine("Enter your name ");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hi " + name);
            Console.WriteLine("You hear the door slowly creek behind you! ");
            Console.WriteLine("Grab a random object ");
            weapon = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("you look behind you and see a silouette of a person do you approach to  ");
            Console.WriteLine("press 1 to investigate or 2 to go through the window and down the fire escape ");
            choice1 = Convert.ToInt32(Console.ReadLine());
            if (choice1 == 1) 
            {
               Console.WriteLine("You approach the figure and it's DAN  ");
               Console.WriteLine("Dan gives an heroic look and says take these it will help and he dissapears");
               weapon = "Banana";
                Console.WriteLine("Press enter to move out of the room and into the hall"); 
               Console.ReadLine();
               Console.Clear();


                

            }
            else if (choice1 == 2)
            {
                Console.Write("You jump out the window and shreek in a high pitched tone, as you move down the fire escape you cut your leg ");
                Console.Write("You see the front door to the building is open and it starts to rain, all of a sudden you hear a scream from inside and you feel a pull to investigate and help.Press Enter to reluctently you go back into the building with your " + weapon + " grasped ");
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("You are walking through the dark hallways you hear a creepy laugh and you sheepishly say \"Dan is that you\" ");
            Console.WriteLine("A creepy clown appears with a knife covered in blood and screams \"Run, Run for your life\" and begins to run at you with a carzed look ");
            Console.WriteLine("As you run down the corridor you see a bathroom on your left what do you do?");
            Console.WriteLine("press 1 to enter the bathroom or press 2 to continue down the corridor");
            choice2 = Convert.ToInt32(Console.ReadLine());
            if (choice2 == 1)
            {
                Console.WriteLine("You run into the bathroom and in the stall, You notice a vent above you and crawl in, the door slams open and says \" " + name + "\" I know you're here");
                Console.WriteLine("He begins to sniff the air and his eyes roll around his head and stare directly into your eyes");
                Console.WriteLine("but he seems to not see you and leaves ");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("As you leave the bathroom the Clown pushes you to the floor and you get up just in time to ");
                Console.WriteLine("press 1 to use your weapon or 2 to try and get past him");
                choice3 = Convert.ToInt32(Console.ReadLine());


                if (choice3 == 1 && weapon == "Banana")
                {
                    Console.WriteLine("You get out the weapon Dan gave you and see it is a banana, the Clowns face drops and he begins to turn around when you slap him the bannana and it opens like an bag and sucks him into the bag and zipped it up, Dan appears and laughs saying \" Well done " + name + " you saved Codenation from destruction!\" Dan gives you 1,000,000 Stu bucks ");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You raise you hand and bring down your mighty " + weapon + " but the clown catches it and eats it whole laughs and stabs you!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("GAME OVER!");
                };


            }
            else
            {
                Console.WriteLine("You continue to run into a dead end and and turn around to see the clown laughing and wielding the bloody knife ");
                Console.WriteLine("press 1 to use your weapon or 2 to try and get past him ");
                choice3 = Convert.ToInt32(Console.ReadLine());

                if (choice3 == 1 && weapon == "Banana")
                {
                    Console.WriteLine("You get out the weapon Dan gave you and see it is a banana, the Clowns face drops and he begins to turn around when you slap him the bannana and it opens like an bag and sucks him into the bag and zipped it up, Dan appears and laughs saying \" Well done " + name + " you saved Codenation from destruction!\" Dan gives you 1,000,000 Stu bucks ");
                    Console.ReadLine();

                }
                else if (choice3 == 1 && weapon != "Banana")
                {

                    Console.WriteLine($"You lunge at him but he jams the kife into your ribs but as you fall, you get out your {weapon} and stick it deep into the clowns side causing you both to colapse and bleed out just before you die Dan appears with a single tear in his eye and says you give your life for codenation and we will remember you.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("You gained Dans respect!");

                }
                else {
                    Console.WriteLine("You try to run around him but trip and fall hitting you head and being stabbed to death");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("GAME OVER!");
                }



            };




            //Console.WriteLine("You use your " + weapon + "and penwise catches and kills you unlucky " + name);


            Console.ReadLine();
        }
    }

}