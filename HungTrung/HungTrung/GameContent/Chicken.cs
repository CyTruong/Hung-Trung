using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HungTrung.GameProperty;
using HungTrung.GameContent.Eggs;
using System.Drawing;
using System.Windows.Forms;

namespace HungTrung.GameContent
{
    class Chicken : GameObject
    {
        Timer timer;
        public Chicken(string name,Tranform.Position position) : base()
        {
            this.tag = "chicken";
            this.name = name;
            this.mask = new Bitmap(HungTrung.Properties.Resources.chicken);
            this.tranform = new Tranform();
            this.tranform.position = position;
            this.rigitbody = new Rigidbody(this);
            this.rigitbody.isColision = false;
            this.rigitbody.isKinematic = false;
            this.rigitbody.isUseGravity = false;
            this.rigitbody.Start();
        }

        public void CreatEgg(int pure_time)
        {
            Random r = new Random();
            int estimated_time = r.Next((int)(pure_time * 0.25), (int)(pure_time * 1.75));
            timer = new Timer();
            timer.Interval = estimated_time;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int eggtype = r.Next(0, 3);
            Eggs.Eggs egg;
            if (eggtype == 0)
            {
                egg = new WhileEgg(this);
            }
            if (eggtype == 1)
            {
                egg = new GoldenEgg(this);
                egg.rigitbody.gravitationSpeed = 30;
            }
            if (eggtype == 2)
            {
                egg = new Shit(this);
            }
            timer.Stop();
            timer.Start();
        }
    }
}
