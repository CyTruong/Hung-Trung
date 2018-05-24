using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HungTrung.GameProperty;

namespace HungTrung.GameContent.Eggs
{
    abstract class Eggs : GameObject
    {
        protected Chicken chicken;
        protected Eggs(Chicken chicken)
        {
            this.chicken = chicken;
            this.tag = "egg";
            this.tranform = new Tranform();
            Tranform.Position startPos = new Tranform.Position(chicken.tranform.position.X + chicken.mask.Width / 2, chicken.tranform.position.Y + chicken.mask.Height);
            this.tranform.position = startPos;


            this.rigitbody = new Rigidbody(this);
            this.rigitbody.isColision = true;
            this.rigitbody.isKinematic = false;
            this.rigitbody.isUseGravity = true;

            this.rigitbody.colider = new Colider(this.rigitbody);
            this.rigitbody.colider.OnHitColision += Colider_OnHitColision;

        }

        protected void EggAnimationFinishEvent(Bitmap defautMask)
        {
            this.rigitbody.isColision = false;
            this.rigitbody.isKinematic = false;
            this.rigitbody.isUseGravity = false;
            this.Destroy();
        }

        private void Colider_OnHitColision(GameProperty.GameObject obj)
        {
            if (obj.name == "crossbar")
            {
                this.rigitbody.isKinematic = false;
                this.rigitbody.isColision = false;
                this.rigitbody.isUseGravity = false;
                this.animation.Start();
            }
           

        }
        protected int scores = 0;

        public int getscores()
        {
            return scores;
        }
       
    }
}
