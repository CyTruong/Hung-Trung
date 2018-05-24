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
using HungTrung.GameContent.Bar;
using System.Media;
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
        private HorizontalBar belowBar;
        private BackGround bg;
        private DateTime startDatetime;
        private string remaintime ="60";


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

            LoadBar();

            main_character = new Bow();

            loadChicken();


            startDatetime = DateTime.Now;
            timer.Start();

            SoundPlayer bmg = new SoundPlayer(HungTrung.Properties.Resources.FarmMusic);
            bmg.Play();

        }

   
        private void LoadBar()
        {
            belowBar = new HorizontalBar();
            HorizontalBar upperBar = new HorizontalBar();
            int y = HungTrung.Properties.Resources.chicken.Height;
            upperBar.tranform.position = new Tranform.Position(0, y);
            upperBar.rigitbody = new Rigidbody(upperBar);
            upperBar.rigitbody.isColision = false;
            upperBar.rigitbody.isKinematic = false;
            upperBar.rigitbody.isUseGravity = false;

            VerticalBar verbar = new VerticalBar();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        { 
            if (this.PointToClient(Control.MousePosition).X <= WindowSize.Width -175)
            {
                main_character.setXposion(this.PointToClient(Control.MousePosition).X);
            }
            else
            {
                main_character.setXposion(WindowSize.Width - 175);
            }

            TimeSpan span = DateTime.Now - startDatetime;
            remaintime = (60 - span.Seconds).ToString();
            if (remaintime == "1")
            {
                stopSpawEgg();
                timer.Stop();
                AddHightsScore addhS = new AddHightsScore(Bow.scores);
                addhS.ShowDialog();
                return; 
            }

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

                Brush b = new SolidBrush(BackColor);


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
            Chicken chicken1 = new Chicken("ga1", new Tranform.Position(ClientSize.Width*1 / 20, 10));
            Chicken chicken2 = new Chicken("ga2", new Tranform.Position(ClientSize.Width*5 / 20, 10));
            Chicken chicken3 = new Chicken("ga3", new Tranform.Position(ClientSize.Width*9 / 20, 10));
            Chicken chicken4 = new Chicken("ga4", new Tranform.Position(ClientSize.Width*13/ 20, 10));
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

            string scores = "scores:\n " +Bow.scores.ToString();
            graph.DrawString(scores, new Font("VnAristote", 20), new SolidBrush(Color.Black), 675, 30);

            graph.DrawString(remaintime.ToString(), new Font("VnAristote", 20), new SolidBrush(Color.Black),700,180);

        }

        private void stopSpawEgg()
        {
            foreach (GameObject obj in GameObject.List_Gameobject)
            {
                if (obj.tag == "chicken")
                {
                    (obj as Chicken).stopCreaatEgg();
                }
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
            this.Close();
          
        }
         
        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Highscorses hs = new Highscorses();
            hs.ShowDialog();
        }

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
