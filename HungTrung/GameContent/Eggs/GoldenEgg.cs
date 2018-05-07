using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace HungTrung.GameContent.Eggs
{
    class GoldenEgg : Eggs
    {
        public GoldenEgg(Chicken chicken) : base(chicken)
        {
            scores = 30;
            this.name = "golden egg";
            this.mask = new Bitmap(HungTrung.Properties.Resources.golden_egg);
            this.rigitbody.colider.SetRectColider(this.mask.Width, this.mask.Height);
            this.rigitbody.Start();
        }
       
    }
}
