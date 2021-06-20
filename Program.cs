using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WierdGameTry
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Functions
            Console.SetWindowSize(212, 49);
            Console.Title = ("Gramoria");
           
            // int's:
            int correct = 0;
            int Int = 0;
            int Str = 0;
            int Dex = 0;
            int Wis = 0;
            int AC = 0;
            int HP = 0;
            //int I||i = 'inv'; ????????? trying to make I or i open inventory???????
            // for the map??




             int ArrayCount = 0;

            //Strings:
            string Gender;
            string Race;
            string Class;
            
            string Input;
            string[] I = new string[40];   //instantiating the array here :)!! for the inv system
            //Game system
            // character generation
            do
            {
                Console.Clear();
                Console.WriteLine("Choose Male or Female:");
                Console.WriteLine("Male / Female");
                Gender = Console.ReadLine();

                if (Gender == "Male")
                {
                    correct = 1;
                }
                if (Gender == "Female")
                {
                    correct = 1;
                }
                else
                {

                    // Console.WriteLine("Choose again, Invalid entry!");
                    //Console.ReadLine();
                }


            }
            while (correct == 0);
            correct = 0;


            // Race

            do
            {
                Console.Clear();
                Console.WriteLine("Choose your Race:");
                Console.WriteLine("Gnome");
                Console.WriteLine("Elf");
                Console.WriteLine("Human");
                Console.WriteLine("Dwarf");
                Console.WriteLine("Drow");
                Console.WriteLine("Your Choice?:");
                Race = Console.ReadLine();
                if (Race == "Gnome")
                {
                    Console.WriteLine("The Gnome starts with:");
                    Console.WriteLine("Int + 1");
                    Console.WriteLine("Str - 3");
                    Console.WriteLine("Dex + 3");
                    Console.WriteLine("Wis + 2");
                    Console.WriteLine("Do you wish to be a Gnome?");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;
                    }
                    if (Input == "No")
                    {
                        correct = 0;
                    }
                }
                if (Race == "Elf")
                {
                    Console.WriteLine("The Elf starts with:");
                    Console.WriteLine("Int + 3");
                    Console.WriteLine("Str - 1");
                    Console.WriteLine("Dex + 1");
                    Console.WriteLine("Wis - 1");
                    Console.WriteLine("Do you wish to be a Elf?");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;
                    }
                    if (Input == "No")
                    {
                        correct = 0;
                    }
                }
                if (Race == "Human")
                {
                    Console.WriteLine("The Human starts with:");
                    Console.WriteLine("Int + 0");
                    Console.WriteLine("Str + 0");
                    Console.WriteLine("Dex + 0");
                    Console.WriteLine("Wis + 0");
                    Console.WriteLine("Do you wish to be a Human?");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;
                    }
                    if (Input == "No")
                    {
                        correct = 0;
                    }
                }
                if (Race == "Dwarf")
                {
                    Console.WriteLine("The Dwarf starts with:");
                    Console.WriteLine("Int + 0");
                    Console.WriteLine("Str + 3");
                    Console.WriteLine("Dex - 2");
                    Console.WriteLine("Wis + 1");
                    Console.WriteLine("Do you wish to be a Dwarf?");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;
                    }
                    if (Input == "No")
                    {
                        correct = 0;
                    }
                }
                if (Race == "Drow")
                {
                    Console.WriteLine("The Drow starts with:");
                    Console.WriteLine("Int + 3");
                    Console.WriteLine("Str - 2");
                    Console.WriteLine("Dex + 1");
                    Console.WriteLine("Wis + 2");
                    Console.WriteLine("Do you wish to be a Drow?");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;
                    }
                    if (Input == "No")
                    {
                        correct = 0;
                    }
                }
            }
            while (correct == 0);
            correct = 0;

            // class

            do
            {
                Console.Clear();
                Console.WriteLine("Choose your Class:");
                Console.WriteLine("Warrior");
                Console.WriteLine("Thief");
                Console.WriteLine("Mage");
                Console.WriteLine("Paladin");
                Console.WriteLine("Dark Warrior");
                Console.WriteLine("Your Choice?:");
                Class = Console.ReadLine();

                if (Class == "Warrior")
                {
                    Console.WriteLine("The Warrior starts with:");
                    Console.WriteLine("Int + 0");
                    Console.WriteLine("Str + 4");
                    Console.WriteLine("Dex + 1");
                    Console.WriteLine("Wis + 0");
                    Console.WriteLine("HP = 15");
                    Console.WriteLine("AC = 0");
                    Console.WriteLine("Do you wish to be a Warrior?");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;
                    }
                    if (Input == "No")
                    {
                        correct = 0;
                    }
                }
                if (Class == "Thief")
                {
                    Console.WriteLine("The Thief starts with:");
                    Console.WriteLine("Int + 1");
                    Console.WriteLine("Str + 0");
                    Console.WriteLine("Dex + 4");
                    Console.WriteLine("Wis + 0");
                    Console.WriteLine("HP = 8");
                    Console.WriteLine("AC = 0");
                    Console.WriteLine("Do you wish to be a Thief?");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;
                    }
                    if (Input == "No")
                    {
                        correct = 0;
                    }
                }
                if (Class == "Mage")
                {
                    Console.WriteLine("The Mage starts with:");
                    Console.WriteLine("Int + 6");
                    Console.WriteLine("Str + 0");
                    Console.WriteLine("Dex + 0");
                    Console.WriteLine("Wis + 0");
                    Console.WriteLine("HP = 5");
                    Console.WriteLine("AC = 0");
                    Console.WriteLine("Do you wish to be a Mage?");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;
                    }
                    if (Input == "No")
                    {
                        correct = 0;
                    }
                }
                if (Class == "Paladin")
                {
                    Console.WriteLine("The Paladin starts with:");
                    Console.WriteLine("Int + 0");
                    Console.WriteLine("Str + 3");
                    Console.WriteLine("Dex + 0");
                    Console.WriteLine("Wis + 3");
                    Console.WriteLine("HP = 12");
                    Console.WriteLine("AC = 0");
                    Console.WriteLine("Do you wish to be a Paladin?");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;
                    }
                    if (Input == "No")
                    {
                        correct = 0;
                    }
                }
                if (Class == "Dark Warrior")
                {
                    Console.WriteLine("The Dark Warrior starts with:");
                    Console.WriteLine("Int + 3");
                    Console.WriteLine("Str + 3");
                    Console.WriteLine("Dex + 0");
                    Console.WriteLine("Wis + 0");
                    Console.WriteLine("HP = 13");
                    Console.WriteLine("AC = 0");
                    Console.WriteLine("Do you wish to be a Dark Warrior?");
                    Input = Console.ReadLine();
                    if (Input == "Yes")
                    {
                        correct = 1;
                    }
                    if (Input == "No")
                    {
                        correct = 0;
                    }
                }

            }
            while (correct == 0);
            correct = 0;

            // Bonuses for race

            if (Race == "Gnome")
            {
                Int = Int + 1;
                Str = Str - 3;
                Dex = Dex + 3;
                Wis = Wis + 2;
            }
            if (Race == "Elf")
            {
                Int = Int + 3;
                Str = Str - 1;
                Dex = Dex + 1;
                Wis = Wis - 1;
            }
            if (Race == "Human")
            {
                Int++;
                Str++;
                Dex++;
                Wis++;
            }
            if (Race == "Dwarf")
            {
                Int++;
                Str = Str + 3;
                Dex = Dex - 2;
                Wis = Wis + 1;
            }
            if (Race == "Drow")
            {
                Int = Int + 3;
                Str = Str - 2;
                Dex = Dex + 1;
                Wis = Wis + 2;
            }
            // Bonuses for class

            if (Class == "Warrior")
            {
                Str = Str + 4;
                Int++;
                Dex = Dex + 1;
                Wis++;
                HP = HP + 15;
                AC++;
            }
            if (Class == "Thief")
            {
                Int = Int + 1;
                Str++;
                Dex = Dex + 4;
                Wis++;
                HP = HP + 8;
                AC++;
            }
            if (Class == "Mage")
            {
                Int = Int + 6;
                Str++;
                Dex++;
                Wis++;
                HP = HP + 5;
                AC++;
            }
            if (Class == "Paladin") // hybred wis caster/ warrior
            {
                Int++;
                Str = Str + 3;
                Dex++;
                Wis = Wis + 3;
                HP = HP + 12;
                AC++;
            }
            if (Class == "Dark Warrior") // hyberd int caster/warrior
            {
                Int = Int + 3;
                Str = Str + 3;
                Dex++;
                Wis++;
                HP = HP + 13;
                AC++;
            }



            // inventory system
            /*  I[1] = "a"; I[2] = "b"; I[3] = "c";
               Console.Clear();

               Console.WriteLine("inventory test: type (I)!");
               Input = Console.ReadLine();

             

               if (Input == "I")
               {
                   Console.Clear();
                   Console.SetCursorPosition(0, ArrayCount);
                   Console.WriteLine("Your Inventory:");
                for (ArrayCount = 0; ArrayCount < 40; ArrayCount++)  
                   {
                       Console.SetCursorPosition(0, ArrayCount);
                       Console.WriteLine("{0}", I[ArrayCount]);
                   }
               }
               else
               {

               }*/
               Console.ReadLine();
            Console.Clear();

            Console.CursorVisible = false;

            Game game = new Game();
            game.Run();

        }
    }
}
