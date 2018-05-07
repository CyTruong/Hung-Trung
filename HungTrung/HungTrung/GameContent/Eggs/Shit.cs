using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HungTrung.GameProperty;

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

            this.animation = new Animation(this, new Bitmap(HungTrung.Properties.Resources.shit_animate), 4, 4);
            this.animation.numberofSprite = 6;
            this.animation.animationTime = 100;
            this.animation.isRepeat = false;
            this.animation.AnimationFinishEvent += EggAnimationFinishEvent;

            this.rigitbody.Start();
        }

       

    }
}
