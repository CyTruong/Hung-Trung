using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HungTrung.GameProperty;
using System.Drawing;

namespace HungTrung.GameContent
{
    class Bow : GameObject
    {
        public static int scores = 0;
        public Bow()
        {
            this.name = "bow";
            this.tag = "bow";
            this.tranform = new Tranform();
            this.mask = new Bitmap(HungTrung.Properties.Resources.bow);
            this.tranform.position.Y = MainGame.WindowSize.Height - (int)(this.mask.Height* 1.4);
            this.rigitbody = new Rigidbody(this);
            this.rigitbody.isColision = true;
            this.rigitbody.isKinematic = false;
            this.rigitbody.isUseGravity = false;
            this.rigitbody.colider = new Colider(this.rigitbody);
            this.rigitbody.colider.SetRectColider(this.mask.Width, this.mask.Height);
            this.rigitbody.colider.OnHitColision += Colider_OnHitColision;
            this.rigitbody.Start();

            scores = 0;
        }

        private void Colider_OnHitColision(GameObject obj)
        {
          
            scores += (obj as Eggs.Eggs).getscores();
            obj.Destroy();
        }

        public void setXposion(int x)
        {
            this.tranform.position.X = x - this.mask.Width / 2 ;
            this.rigitbody.colider.UpdateColider(this.tranform);
        }
    }
}
