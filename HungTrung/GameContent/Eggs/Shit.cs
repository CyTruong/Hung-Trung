using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HungTrung.GameContent.Eggs
{
    class Shit : Eggs
    {
        public Shit(Chicken chicken) : base(chicken) 
        {
            scores = -10;
            this.name = "Shit";
            this.mask = new Bitmap(HungTrung.Properties.Resources.shit);
            this.rigitbody.colider.SetRectColider(this.mask.Width, this.mask.Height);
            this.rigitbody.Start();
        }
      
    }
}
