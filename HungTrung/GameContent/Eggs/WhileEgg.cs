using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HungTrung.GameProperty;

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


            this.animation = new Animation(this, new Bitmap(HungTrung.Properties.Resources.egg_pop_animate), 4, 4);
            this.animation.numberofSprite = 6;
            this.animation.animationTime =200;
            this.animation.isRepeat = false;
            this.animation.AnimationFinishEvent += EggAnimationFinishEvent;

            this.rigitbody.Start();
        }



    }
}
