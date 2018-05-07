using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

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
        private int rows,colums;
        private int curIndex;
        private Bitmap defautMask;
        private Thread aniThread;
        public Animation(GameObject obj,Bitmap bm,int row, int colum)
        {
            this.gameobj = obj;
            this.rows = row;
            this.colums = colum;
            this.animationSprite = bm;
            this.defautMask = obj.mask;
            this.numberofSprite = row * colum;
            animationTime = MainGame.UPDATE_SCRREEN_TIME;
            isRepeat = false;
        }

        public void Start()
        {
            this.gameobj.mask = new Bitmap(HungTrung.Properties.Resources._null);
            FixTranformPosition();
            aniThread = new Thread(new ThreadStart(updateMask));
            aniThread.Start();
        }

        private void updateMask()
        {

            while (true)
            {
                Thread.CurrentThread.Join(animationTime);
                if (curIndex > numberofSprite &&!isRepeat)
                {
                    break;
                }
                if (curIndex > numberofSprite)
                {
                    curIndex = 0;
                }
                gameobj.mask = getAnimationBitmap(curIndex);
                curIndex++;
            }
               AnimationFinishEvent(defautMask);
         
        }

        private Bitmap getAnimationBitmap(int index)
        {
            Console.WriteLine("aniation index "+ index);
            try
            {
                int miniW = animationSprite.Width / colums;
                int miniH = animationSprite.Height / rows;
                int nW = index % colums;
                int nH = index % rows;
                Rectangle cuttingRect = new Rectangle(nW * miniW, nH * miniH, miniW, miniH);
                return animationSprite.Clone(cuttingRect, animationSprite.PixelFormat);
            }
            catch (InvalidOperationException)
            {
                return getAnimationBitmap(index);
            }
           
        }

        private void  FixTranformPosition()
        {
            this.gameobj.tranform.position.Y = this.gameobj.tranform.position.Y - animationSprite.Height / (2*rows);
            this.gameobj.tranform.position.X = this.gameobj.tranform.position.X - animationSprite.Width / (2 * colums);
        }
    }
}
