using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungTrung.GameProperty
{
    struct Rectangel
    {
        /// <summary>
        /// Góc trái trên 
        /// </summary>
        public Tranform tranform { get; set; }
        public int W { get; set; }
        public int H { get; set; }

    }

    struct Circel
    {
        public float R { get; set; }
        public Tranform tranform { get; set; }
    }

    partial class Colider
    {
       
        public delegate void OnColisionEvent(GameObject obj);
        /// <summary>
        /// Sự khiện va chạm vớ colider khác
        /// </summary>
        public event OnColisionEvent OnHitColision;

        enum Shapetype
        {
            Rectangle,
            Circle
        }
        private Rectangel RecColider;
        private Circel CirColider;
        private Shapetype type;
        private Rigidbody rigidbody;

        public string teststring { get; set; }

        public Colider(Rigidbody ri)
        {
            this.rigidbody = ri;
            this.type = Shapetype.Rectangle;
            RecColider.tranform = new Tranform();
        }

        public Colider(Colider colider)
        {
            if (type==Shapetype.Circle)
            {
                this.type = Shapetype.Circle;
                this.CirColider = colider.CirColider;
            }
            if (type == Shapetype.Rectangle)
            {
                this.type = Shapetype.Rectangle;
                this.RecColider = colider.RecColider;
            }
        }

        public void SetCircleColider(float R)
        {
            CirColider.R = R;
            type = Shapetype.Circle;
        }

        public void SetRectColider(int w, int h)
        {
            RecColider.W = w;
            RecColider.H = h;
            type = Shapetype.Rectangle;
        }

        /// <summary>
        /// Thay đổi Tranform của Colider
        /// </summary>
        /// <param name="x"></param>
        public void UpdateColider(Tranform x)
        {
            if (type == Shapetype.Circle)
            {
                CirColider.tranform = x;
            }
            if (type == Shapetype.Rectangle)
            {
                RecColider.tranform = x;
            }
            checkColision();
        }

        /// <summary>
        /// Thay dịch chuyển Tranform đi
        /// </summary>
        /// <param name="x"> Vector dịch chuyển </param>
        public void UpdateColider(Tranform.Position x)
        {
            if (type == Shapetype.Circle)
            {
                CirColider.tranform.position += x;
            }
            if (type == Shapetype.Rectangle)
            {
                RecColider.tranform.position += x;
            }
            checkColision();

        }

        private void checkColision()
        {
          
            bool check;
            GameObject.isInUsingList = true;
            try
            {
                for (int i = 0; i < GameObject.List_Gameobject.Count; i++)
                {

                    GameObject obj = GameObject.List_Gameobject[i];


                    if (obj.name != this.rigidbody.gameobj.name && obj.rigitbody.isColision)
                    {
                        if (this.type == obj.rigitbody.colider.type && this.type == Shapetype.Circle && obj != null)
                        {
                            check = checkColision_cir_cir(obj);
                        }
                        else
                        if (this.type == obj.rigitbody.colider.type && this.type == Shapetype.Rectangle)
                        {
                            check = checkColision_rec_rec(obj);
                        }
                        else
                        if (this.type != obj.rigitbody.colider.type && this.type == Shapetype.Rectangle)
                        {
                            check = checkColision_rec_cir(obj);
                        }
                        else
                            check = checkColision_cir_rec(obj);

                        if (check)
                        {

                            OnHitColision(obj);
                        }
                    }
                }
            }
           catch (NullReferenceException e1)
            {

            }
            catch (IndexOutOfRangeException e2)
            {

            }
            //foreach (GameObject obj in GameObject.List_Gameobject)
            //{            
            //}
            GameObject.isInUsingList = false;
        }

        private bool checkColision_rec_rec(GameObject obj)
        {
            int x = Math.Abs((this.RecColider.tranform.position.X + this.RecColider.W /2)  - (obj.rigitbody.colider.RecColider.tranform.position.X + obj.rigitbody.colider.RecColider.W / 2));
            int w = Math.Abs(this.RecColider.W - obj.rigitbody.colider.RecColider.W);
            int y = Math.Abs((this.RecColider.tranform.position.Y + this.RecColider.H / 2) - (obj.rigitbody.colider.RecColider.tranform.position.Y + obj.rigitbody.colider.RecColider.H / 2));
            int h = Math.Abs(this.RecColider.H - obj.rigitbody.colider.RecColider.H);

            if (x<= w && y <=h)
            {
                return true;
            }
            return false;
        }

        private bool checkColision_cir_cir(GameObject obj)
        {
            int dx = this.CirColider.tranform.position.X - obj.rigitbody.colider.CirColider.tranform.position.X;
            int dy = this.CirColider.tranform.position.Y - obj.rigitbody.colider.CirColider.tranform.position.Y;
            float l = this.CirColider.R + obj.rigitbody.colider.CirColider.R;
            if (dx*dx + dy*dy <= l*l)
            {
                return true;
            }

            return false;

        }

        private bool checkColision_rec_cir(GameObject obj)
        {
            return false;
        }

        private bool checkColision_cir_rec(GameObject obj)
        {
            return false;
        }


    }
}
