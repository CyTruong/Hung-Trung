using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing;

namespace HungTrung.GameProperty
{ 
    class Animation
    {

        public Bitmap animationSprite { get; set; }
        public int animationTime { get; set; }  
        public int numberofSprite { get; set; }
        public bool isRepeat { get; set; }
        public delegate void AnimationFinishDelegate(Bitmap defautMask);
        public event AnimationFinishDelegate AnimationFinishEvent;

        private GameObject gameobj;
        private Timer timer;
        private int rows,colums;
        private int curIndex;
        private Bitmap defautMask;

        public Animation(GameObject obj,Bitmap bm,int row, int colum)
        {
            this.gameobj = obj;
            this.rows = row;
            this.colums = colum;
            this.animationSprite = bm;
            this.defautMask = obj.mask;
            animationTime = MainGame.UPDATE_SCRREEN_TIME;
            isRepeat = false;
        }

        public void Start()
        {
            timer = new Timer();
            timer.Interval = animationTime;
            timer.Tick += updateMask;
            timer.Start();
        }

        private void updateMask(object sender, EventArgs e)
        {
            curIndex++;
            if (curIndex> numberofSprite)
            {
                curIndex = 0;
            }
            gameobj.mask = getAnimationBitmap(curIndex);
            timer.Stop();
            if (isRepeat)
            {
                timer.Start();
            }
            else
            {
                AnimationFinishEvent(defautMask);
            }
            
        }

        private Bitmap getAnimationBitmap(int index)
        {
            int miniW = animationSprite.Width / colums;
            int miniH = animationSprite.Height / rows;
            int nW = index % colums;
            int nH = index % rows;
            Rectangle cuttingRect = new Rectangle(nW * miniW, nH * miniH,miniW,miniH);
            return animationSprite.Clone(cuttingRect, animationSprite.PixelFormat);
        }

      
    }
}
