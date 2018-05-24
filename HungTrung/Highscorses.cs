using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HungTrung
{
    public partial class Highscorses : Form
    {
        public Highscorses()
        {
            InitializeComponent();
            initListview();
            
        }

        private void  initListview()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            path += @"\data.cy";
            List<playerHightScores> list = new List<playerHightScores>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] separator = new string[] { "||@||" };
                    string[] info = line.Split(separator,StringSplitOptions.RemoveEmptyEntries);
                    playerHightScores hs;
                    hs.name = info[0];
                    hs.scores = int.Parse(info[1].ToString());
                    list.Add(hs);
                }
                list.Sort((s1,s2)=>s2.scores.CompareTo(s1.scores));
            }
            foreach (playerHightScores s in list)
            {
                ListViewItem item = new ListViewItem(s.name + "  "+s.scores);
                lvHightScores.Items.Add(item);
            }
            lvHightScores.View = View.Tile;
            lvHightScores.Show();
        }

        internal struct playerHightScores
        {
          public string name;
          public int scores;
        }
    }
}
