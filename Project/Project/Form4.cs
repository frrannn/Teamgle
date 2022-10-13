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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int IdEquipo = 1;
        //OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ADM\Documents\GitHub\Teamgle\Project\Project\bin\Debug\TEAMGLE.accdb");
        //conexion.Open();
        // ( quiero que en el label me muestre la liga del ide 1 )label2.text = "SELECT liga FROM EquiposFaciles WHERE Id = " + IdEquipo + "";
        //OleDbCommand comando = new OleDbCommand(comprobacion, conexion);
        //OleDbDataReader lector;
        //lector = comando.ExecuteReader();
        //        Boolean existencia = lector.HasRows;
        //        if (existencia)
        //        {

        //            MessageBox.Show("El dato existe");

        //        }
    private void Button2_Click(object sender, EventArgs e)
        {
            Form2 FrancoRusso = new Form2();
            FrancoRusso.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
