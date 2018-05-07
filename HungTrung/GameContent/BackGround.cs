using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HungTrung.GameContent;
using HungTrung.GameProperty;

namespace HungTrung.GameContent
{
    class BackGround : GameObject
    {
        public BackGround()
        {
            this.name = "backGround";
            this.mask = new Bitmap(HungTrung.Properties.Resources.farm);

            this.mask = new Bitmap(mask,new Size((int)(mask.Width*1.5),(int)(mask.Height*1.5)));
            this.tranform.position = new Tranform.Position(0, 0);
            this.tranform.size = new Tranform.Size(1.7, 1.7);

            this.rigitbody = new Rigidbody(this);
            this.rigitbody.isColision = false;
            this.rigitbody.isKinematic = false;
            this.rigitbody.isUseGravity = false;
        }
    }
}
