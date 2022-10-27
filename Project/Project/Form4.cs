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
    
    public partial class Form4 : Form
    {
        string EquipoCorrecto;
        
     
        public Form4()
        {

//En C# todo debe estar dentro de una clase asi que lo que peueds hacer es crear una
//clase llamada Gloables y alli definir todas tus variables como propiedades.
//Yo suelo crear una clase P y en ella declaro las variables como public static,
//pudiendo acceder a ellas desde cualquier sitio tan solo añadiendo P.Variable,
//comportandose asi igual que si las declarases en un modulo de visual basic
        

        InitializeComponent();

            DataTable dt = new DataTable();

            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TEAMGLE.accdb;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();

            
            {

                string query = "select * from EquiposFaciles";

                OleDbCommand cmd = new OleDbCommand(query, connection);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);

            }
            datagrid.DataSource = dt;
            EquipoCorrecto= datagrid.Rows[0].Cells[1].Value.ToString();
            connection.Close();
            
            Liga.Text = datagrid.Rows[0].Cells[2].Value.ToString();
            Fundacion.Text = datagrid.Rows[0].Cells[3].Value.ToString();
            Titulos.Text = datagrid.Rows[0].Cells[4].Value.ToString();
            RowEq.Text = "0";
            CantAciertos.Text = "0";
            CantError.Text = "0";


            //var ValidadorEq = new validador();
            //ValidadorEq.txtValido = "River Plate";
            //ValidadorEq.txtaValidar =  "river ";



            //  string connetionString = null;
            // OleDbConnection connection;
            // OleDbDataAdapter oledbAdapter;
            //  string sql = null;


            //   DataSet ds = new DataSet();


            //connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TEAMGLE.accdb;";
            //    sql = "SELECT * FROM EquiposFaciles where iD between 1 and 10";
            //    connection = new OleDbConnection(connetionString);
            //    try
            //    {
            //        connection.Open();
            //        oledbAdapter = new OleDbDataAdapter(sql, connection);
            //        oledbAdapter.Fill(ds);
            //        oledbAdapter.Dispose();
            //        connection.Close();
            //        Equipo.Text = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[1]);
            //        Liga.Text = Convert.ToString (ds.Tables[0].Rows[0].ItemArray[2]);
            //        Fundacion.Text = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[3]);
            //        Titulos.Text = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[4]);



            //               for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            //               {
            //                   MessageBox.Show(ds.Tables[0].Rows[i].ItemArray[0] + " -- " + ds.Tables[0].Rows[i].ItemArray[1] + " -- " + ds.Tables[0].Rows[i].ItemArray[2] + " -- " + ds.Tables[0].Rows[i].ItemArray[3]+ " -- " + ds.Tables[0].Rows[i].ItemArray[4] + " -- " + ds.Tables[0].Rows[i].ItemArray[5]);
            //               }
            //}
            //catch (Exception ex)
            //{ 
            //    MessageBox.Show("Can not open connection ! ");

            //}


        }



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
          
            


            if (textBox1.Text == EquipoCorrecto)

            {
                MessageBox.Show("acertaste");
                textBox1.Text = "";
                RowEq.Text = Convert.ToString(Convert.ToInt32(RowEq.Text)+ 1);
               CantAciertos.Text = Convert.ToString(Convert.ToInt32(CantAciertos.Text) + 1);

                EquipoCorrecto = datagrid.Rows[Convert.ToInt32(RowEq.Text)].Cells[1].Value.ToString();
                Liga.Text = datagrid.Rows[Convert.ToInt32(RowEq.Text)].Cells[2].Value.ToString();
                Fundacion.Text = datagrid.Rows[Convert.ToInt32(RowEq.Text)].Cells[3].Value.ToString();
                Titulos.Text = datagrid.Rows[Convert.ToInt32(RowEq.Text)].Cells[4].Value.ToString();

                Fundacion.Visible = false;
                Titulos.Visible = false;
            }

            else
            {


                if (Titulos.Visible)
                {

                    MessageBox.Show("perdiste");
                    CantError.Text = Convert.ToString(Convert.ToInt32(CantError.Text) + 1);
                    textBox1.Text = "";
                    RowEq.Text = Convert.ToString(Convert.ToInt32(RowEq.Text) + 1);

                    EquipoCorrecto = datagrid.Rows[Convert.ToInt32(RowEq.Text)].Cells[1].Value.ToString();
                    Liga.Text = datagrid.Rows[Convert.ToInt32(RowEq.Text)].Cells[2].Value.ToString();
                    Fundacion.Text = datagrid.Rows[Convert.ToInt32(RowEq.Text)].Cells[3].Value.ToString();
                    Titulos.Text = datagrid.Rows[Convert.ToInt32(RowEq.Text)].Cells[4].Value.ToString();

                    Fundacion.Visible = false;
                    Titulos.Visible = false;

                }


           else     if (Fundacion.Visible)
                {
                    MessageBox.Show("No acertaste");
                    textBox1.Text = "";
                    Titulos.Visible = true;

                }


                else
                {
                    MessageBox.Show("No acertaste");
                    textBox1.Text = "";
                    Fundacion.Visible = true;
                }
                   
                
            }


            
               

            


                
        }



        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tEAMGLEDataSet.EquiposFaciles' Puede moverla o quitarla según sea necesario.
            //this.equiposFacilesTableAdapter.Fill(this.tEAMGLEDataSet.EquiposFaciles);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        this.equiposFacilesTableAdapter.FillBy(this.tEAMGLEDataSet.EquiposFaciles);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        }

        private void Liga_Click(object sender, EventArgs e)
        {

        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Equipo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Mensajefin_Click(object sender, EventArgs e)
        {

        }

        private void Escudo_Click(object sender, EventArgs e)
        {

        }

        private void Titulos_Click(object sender, EventArgs e)
        {

        }

        private void Fundacion_Click(object sender, EventArgs e)
        {

        }

        private void RowEq_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
