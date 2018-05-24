using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HungTrung.GameProperty;
using System.Drawing;

namespace HungTrung.GameContent.Bar
{
    class HorizontalBar : GameObject
    {
        public HorizontalBar()
        {
            this.name = "crossbar";
            this.tag = "bar";
            this.mask = new Bitmap(HungTrung.Properties.Resources.bar);
            this.tranform = new Tranform();
            this.tranform.position = new Tranform.Position(0, MainGame.WindowSize.Height - this.mask.Height);
            this.rigitbody = new Rigidbody(this);
            this.rigitbody.isColision = true;
            this.rigitbody.isKinematic = false;
            this.rigitbody.isUseGravity = false;
            this.rigitbody.colider = new Colider(this.rigitbody);
            this.rigitbody.colider.SetRectColider(this.mask.Width, this.mask.Height);
            this.rigitbody.Start();

        }
    }
}
