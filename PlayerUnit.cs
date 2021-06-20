using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WierdGameTry
{
    public class PlayerUnit : Units
    {
        public PlayerUnit(int x, int y, string unitGraphic) : base(x, y, unitGraphic)
        {

        }

        override public void Update()
        {
            // when the PLAYER's update function gets called
            // we would like to execute this instead of
            // our parent class's update.(OVERRIDE the parent)
            // the (override) function will mave it run over
            // the parent virtual function!!??

            // do keyboard input HEEEEEE!!!!!
            if (Console.KeyAvailable == true)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.NumPad9:
                        X = X + 1;
                        Y = Y - 1;
                        break;
                    case ConsoleKey.NumPad7:
                        X = X - 1;
                        Y = Y - 1;
                        break;
                    case ConsoleKey.NumPad3:
                        X = X + 1;
                        Y = Y + 1;
                        break;
                    case ConsoleKey.NumPad1:
                        X = X - 1;
                        Y = Y + 1;
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                    case ConsoleKey.NumPad8:
                        Y = Y - 1;
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                    case ConsoleKey.NumPad2:
                        Y = Y + 1;
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                    case ConsoleKey.NumPad4:
                        X = X - 1;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                    case ConsoleKey.NumPad6:
                        X = X + 1;
                        break;
                    case ConsoleKey.I:
                    //    I = I + 1;
                       // I || i == inv,
                        break;
                }
            }

            // Now that the keyboard input is done call the base UPDATE because it
            // may have inportant work to do
            base.Update();


        }
    }
}
