using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Form1 : Form
    {

        GameDoubler gameDoubler;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rand = random.Next(1,101);
            MessageBox.Show($"Необходимо получить число {rand}");
            gameDoubler = new GameDoubler(rand);
            UpdateInfo();
            btnMulti.Enabled = true;
            btnPlus.Enabled = true;
            btnReset.Enabled = true;
            btnBack.Enabled = true;
            gameDoubler.SetUpdate += UpdateInfo;

        }

        void UpdateInfo()
        {
            lblCurrent.Text = gameDoubler.Current.ToString();
            lblFinish.Text = gameDoubler.Finish.ToString();
            lCommandCounter.Text = gameDoubler.Count.ToString();
            //lblMinCount.Text = gameDoubler.MinCount.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (gameDoubler == null) return;
            gameDoubler.Plus();            
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (gameDoubler == null) return;
            gameDoubler.Multi();            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (gameDoubler == null) return;
            gameDoubler.Reset();           
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            newToolStripMenuItem.PerformClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            gameDoubler.Back();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}
