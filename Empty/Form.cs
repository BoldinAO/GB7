using System;
using System.Drawing;
using System.Windows.Forms;

namespace Empty
{
    class Form1: Form
    {
        Button btnMulti,btnPlus;
        Label lblCurrent;

        public Form1()
        {
            Init();
        }

        private void Init()
        {
            btnMulti = new Button();
            btnPlus = new Button();
            lblCurrent = new Label();
            btnMulti.Top = 100;
            lblCurrent.Left = 200;
            btnMulti.Text = "x2";
            btnPlus.Text = "+1";
            lblCurrent.Text = "1";
            btnPlus.Click += BtnPlus_Click;
            this.Controls.Add(btnMulti);
            this.Controls.Add(btnPlus);
            this.Controls.Add(lblCurrent);
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            lblCurrent.Text = (int.Parse(lblCurrent.Text) + 1).ToString();
        }
    }


    static class Program
    {
        static void Main()
        {
            Form1 form = new Form1();
            //Console.WriteLine("aasd");
            Application.Run(form);


        }
    }
}