using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HungTrung.GameProperty;
using HungTrung.GameContent;
using HungTrung.GameContent.Eggs;
using System.IO;

namespace HungTrung
{
    public partial class MainGame : Form
    {
        public const int UPDATE_SCRREEN_TIME = 70;
        public static Size WindowSize ; 
        private Timer timer;
        private Graphics graph;
        private Bow main_character;
        private Bar belowBar;
        private BackGround bg;

        public MainGame()
        {
            InitializeComponent();
            MainGame.WindowSize = ClientSize;
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = UPDATE_SCRREEN_TIME;
            timer.Tick += Timer_Tick;


            bg = new BackGround();
            

            main_character = new Bow();

            LoadBar();

            loadChicken();

            timer.Start();

            
        }

        private void LoadBar()
        {
            belowBar = new Bar();
            Bar upperBar = new Bar();
            int y = HungTrung.Properties.Resources.chicken.Height;
            upperBar.tranform.position = new Tranform.Position(0, y);
            upperBar.rigitbody = new Rigidbody(upperBar);
            upperBar.rigitbody.isColision = false;
            upperBar.rigitbody.isKinematic = false;
            upperBar.rigitbody.isUseGravity = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        { 
            main_character.setXposion(this.PointToClient(Control.MousePosition).X);
            lbobj.Text = GameObject.List_Gameobject.Count.ToString();
            lbScores.Text = Bow.scores.ToString();
            Invalidate();
            timer.Stop();
            timer.Start();
           // Console.WriteLine(GameObject.List_Gameobject.Count + "Element");
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Bitmap _backbuffer = new Bitmap(this.ClientSize.Width, this.ClientSize.Height))
            {
                graph = Graphics.FromImage(_backbuffer);
                graph.Clear(Color.Black);
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                /// draw songthing from here
                drawing();
                /// load back buffer
                graph.Dispose();
                e.Graphics.DrawImageUnscaled(_backbuffer, 0, 0);
            }
        }

        
        private void loadChicken()
        {
            Chicken chicken1 = new Chicken("ga1", new Tranform.Position(ClientSize.Width*0 / 20, 10));
            Chicken chicken2 = new Chicken("ga2", new Tranform.Position(ClientSize.Width*4 / 20, 10));
            Chicken chicken3 = new Chicken("ga3", new Tranform.Position(ClientSize.Width*8 / 20, 10));
            Chicken chicken4 = new Chicken("ga4", new Tranform.Position(ClientSize.Width*12/ 20, 10));
            chicken1.CreatEgg(3500);
            chicken2.CreatEgg(2500);
            chicken3.CreatEgg(3300);
            chicken4.CreatEgg(4000);
        }

   

        private void drawing()
        {
            try
            {
                foreach (GameObject obj in GameObject.List_Gameobject)
                {
                    graph.DrawImage(obj.getBitmap(), obj.tranform.position.X, obj.tranform.position.Y);
                }
            }
            catch (InvalidOperationException e)
            {

            }

        }

      

    }
}
