using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace HungTrung.GameContent.Eggs
{
    class WhileEgg : Eggs
    {
        public WhileEgg(Chicken chicken) : base(chicken)
        {
            scores = 10;
            this.name = "Whileegg";
            this.mask = new Bitmap(HungTrung.Properties.Resources.white_egg);
            this.rigitbody.colider.SetRectColider(this.mask.Width, this.mask.Height);
            this.rigitbody.Start();
        }



    }
}
