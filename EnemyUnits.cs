using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WierdGameTry
{
    public class EnemyUnits : Units
    {
        public EnemyUnits(int x, int y, string unitGraphic) : base(x, y, unitGraphic)
        {

        }
        public override void Update()
        {
            // AI here HEEEEEEEEE!!!!!!!

            // Now that the AI is done call the base UPDATE because it
            // may have inportant work to do
            base.Update();
        }
    }
}
