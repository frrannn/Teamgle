using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Project
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            OleDbConnection BaseDeDatosProyecto;

            BaseDeDatosProyecto = new OleDbConnection();
            BaseDeDatosProyecto.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TEAMGLE.accdb;";
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            Form6 niveldificil = new Form6();
            niveldificil.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form1 FrancoRusso = new Form1();
            FrancoRusso.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 Nivelfacil = new Form4();
            Nivelfacil.Show();
            this.Hide();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form5 nivelmedio = new Form5();
            nivelmedio.Show();
            this.Hide();
        }
    }
}
