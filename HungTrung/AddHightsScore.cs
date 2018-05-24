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
    public partial class AddHightsScore : Form
    {
        string username;
        int scores;
        public AddHightsScore( int scores)
        {
            this.scores = scores;
            InitializeComponent();
            lbScores.Text = "SCORES : " + this.scores.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.username = tbname.Text;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            path += @"\data.cy";
            using (StreamWriter writer = new StreamWriter(path, true)) 
            {
                writer.WriteLine(username +"||@||"+scores);
            }

            this.Close();
        }
       

    }
}
