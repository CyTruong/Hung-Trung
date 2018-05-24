using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HungTrung.GameProperty;
using System.Drawing;

namespace HungTrung.GameContent.Bar
{
    class VerticalBar : GameObject
    {
        public VerticalBar()
        {
            this.name = "crossbar";
            this.tag = "bar";
            this.mask = new Bitmap(HungTrung.Properties.Resources.bar2);
            this.tranform = new Tranform();
            this.tranform.position = new Tranform.Position(MainGame.WindowSize.Width - 150, 0);
            this.rigitbody = new Rigidbody(this);
            this.rigitbody.isColision = false;
            this.rigitbody.isKinematic = false;
            this.rigitbody.isUseGravity = false;
            this.rigitbody.colider = new Colider(this.rigitbody);
            this.rigitbody.colider.SetRectColider(this.mask.Width, this.mask.Height);
            this.rigitbody.Start();

        }

    }
}
