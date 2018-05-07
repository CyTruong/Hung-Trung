using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;

namespace HungTrung.GameProperty

{
    class GameObject
    {
        public static List<GameObject> List_Gameobject = new List<GameObject>();
        public static bool isInUsingList = false;

        public string name { get; set; }
        public string tag { get; set; }
        public Tranform tranform { get; set; }
        public Rigidbody rigitbody {get; set;}
        public Animation animation { get; set;  }
        public Bitmap mask { get; set;  }

        public GameObject()
        {
            tranform = new Tranform();
          
            GameObject.List_Gameobject.Add(this);
        }

     
        public void Start()
        {
            if (rigitbody != null)
            {
                rigitbody.Start();
            }
        }

        public void Destroy()
        {
            while (GameObject.isInUsingList) { }
            List_Gameobject.Remove(this);
        }
        
    }
}
