using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

          private void Button1_Click(object sender, EventArgs e)
        {
            Form2 FrancoRusso = new Form2();
            FrancoRusso.Show();
            this.Hide();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 FrancoRusso = new Form3();
            FrancoRusso.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
      

    }
}
