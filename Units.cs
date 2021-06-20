using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WierdGameTry
{
    abstract public class Units  // the (ABSTRACT) function makes it so that Units() can never be calld itself!!  
    {                           // must add enemyUnits, playerUnits, chestUnit etx....


        public Units(int x, int y, string unitGraphic)
        {
            this.UnitGraphic = unitGraphic;
            this.X = x;
            this.Y = y;
        }


        public int X   //the way the rest of the program interacts with X
        {
            get
            {
                return _x;
            }
            set
            {     // this makes sure we dont put wrong coordanates in for unit values!!
                if (value < 0 || value >= Console.WindowWidth)
                {
                    throw new Exception("Invalad X coordinate passed.");
                }
                Undraw();  //we are moving so undraw the old spots!!
                _x = value;

                // additional things may happen, like checks to see if were in deep water or out of bounds like above.

            }
        }
        private int _x; // Where the value of x is actually stored

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                if (value < 0 || value >= Console.WindowHeight)
                {
                    throw new Exception("Invalad Y coordinate passed.");
                }
                Undraw(); //we are moving so undraw the old spots!!
                _y = value;
            }
        }
        private int _y; // Where the value of y is actually stored




        public string UnitGraphic { get; set; }

        virtual public void Update()
        {
            //the idea is all units update themselves, then all units will draw??
            // this resolves any gamy things, going on
            // since this update runs for both enemys AND players
            // the child classes need to OVERRIDE the update.
            // The (virtual) function makes C# do more "babysitting"
            // will make it check to see which update it should really run!!??

        }

        // this draws the unit on the screen
        public void Draw()
        {
            //this is an instance method, so if we refer
            //to fields like x and y, we will be using
            //the values that belong to this instance,
            // and this instance ONLY.
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write(this.UnitGraphic);
        }

        public void Undraw()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write(' ');
        }

    }
}
