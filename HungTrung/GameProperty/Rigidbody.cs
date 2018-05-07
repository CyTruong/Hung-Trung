using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HungTrung.GameProperty
{

    class Rigidbody
    {
        public int gravitationSpeed {get; set;} 


        public bool isKinematic;
        public bool isUseGravity;
        public bool isColision;
        public Tranform direction = new Tranform();
        public GameObject gameobj;
        public Colider colider { get; set; }

        private Thread giridThread;

        public Rigidbody( GameObject gameobj)
        {
            gravitationSpeed = 15;
            isKinematic = false;
            isUseGravity = false;
            isColision = false;
            this.gameobj = gameobj;
        }

        public void Start()
        {


            giridThread = new Thread(new ThreadStart (Update));
            giridThread.Name = "Gigidbody Thread";
            giridThread.Start();
        }

        public void Update()
        {
            while (true)
            {
                if (isUseGravity)
                {
                    gameobj.tranform = gameobj.tranform + gravitationSpeed * Tranform.Down;
                }
                if (isKinematic)
                {
                    gameobj.tranform = gameobj.tranform + direction;
                }
                if (isColision)
                {
                    colider.UpdateColider(gameobj.tranform);            
                }
                //Console.WriteLine("X Y :"+gameobj.tranform.position.X +" "+gameobj.tranform.position.Y);

                //if (gameobj.tranform.position.Y > MainGame.WindowSize.Height )
                //{
                //    gameobj.Destroy();
                   
                //}
                Thread.Sleep(100);
            }
        }

        public void Stop()
        {
            giridThread.Abort();
        }

        //////////////////////////////


        

    }
}
