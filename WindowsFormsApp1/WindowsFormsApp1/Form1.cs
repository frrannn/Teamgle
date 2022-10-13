using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            static string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + Application.StartupPath + "/TEAMGLE.mdb";
            OleDbConnection dbcon = new OleDbConnection(constr);

            OleDbCommand cmd = dbcon.CreateCommand();
            dbcon.Open();
            cmd.CommandText = "Insert into EmployeeInfo (Ename, Edept,Eaddress)Values('" + txtEmpname.Text + "','" + txtEmpdept.Text + "','" + txtEmpaddress.Text + "')";
            cmd.Connection = dbcon;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully");
            dbcon.Close();
        }

 

        private void titulos_Click(object sender, EventArgs e)
        {

        }

        private void Liga_Click(object sender, EventArgs e)
        {

        }

        private void NombreEq_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fundacion_Click(object sender, EventArgs e)
        {

        }
    }
}
