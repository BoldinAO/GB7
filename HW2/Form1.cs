using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
    public partial class Form1 : Form
    {
        GuessTheNumber guessTheNumber;

        public Form1()
        {
            InitializeComponent();
            guessTheNumber = new GuessTheNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guessTheNumber.Compare(TbUserNumber.Text);
        }
    }
}
