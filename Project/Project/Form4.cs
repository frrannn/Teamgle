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
        public Form4()
        {

//En C# todo debe estar dentro de una clase asi que lo que peueds hacer es crear una
//clase llamada Gloables y alli definir todas tus variables como propiedades.
//Yo suelo crear una clase P y en ella declaro las variables como public static,
//pudiendo acceder a ellas desde cualquier sitio tan solo añadiendo P.Variable,
//comportandose asi igual que si las declarases en un modulo de visual basic
            InitializeComponent();
            string connetionString = null;
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter;
            string sql = null;
            int i = 0;
            DataSet ds = new DataSet();


            connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TEAMGLE.accdb;";
            sql = "SELECT * FROM EquiposFaciles where iD between 1 and 10";
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                oledbAdapter = new OleDbDataAdapter(sql, connection);
                oledbAdapter.Fill(ds);
                oledbAdapter.Dispose();
                connection.Close();

                Liga.Text = Convert.ToString (ds.Tables[0].Rows[0].ItemArray[2]);
                Fundacion.Text = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[3]);
                Titulos.Text = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[4]);

             

                //               for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                //               {
                //                   MessageBox.Show(ds.Tables[0].Rows[i].ItemArray[0] + " -- " + ds.Tables[0].Rows[i].ItemArray[1] + " -- " + ds.Tables[0].Rows[i].ItemArray[2] + " -- " + ds.Tables[0].Rows[i].ItemArray[3]+ " -- " + ds.Tables[0].Rows[i].ItemArray[4] + " -- " + ds.Tables[0].Rows[i].ItemArray[5]);
                //               }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Can not open connection ! ");

            }


                //            OleDbConnection BaseDeDatosProyecto;

                //            BaseDeDatosProyecto = new OleDbConnection();
                //            BaseDeDatosProyecto.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TEAMGLE.accdb;";
                //            int IdEquipo = 1;
                //            OleDbCommand Ligad;
                //            BaseDeDatosProyecto.Open();
                //            string sql = "SELECT liga FROM EquiposFaciles WHERE Id = " + IdEquipo + "";

                //            Ligad = new OleDbCommand(sql, BaseDeDatosProyecto);
                //            OleDbDataAdapter da = new OleDbDataAdapter(Ligad);

                //            DataSet ds = new DataSet();
                //            da.Fill(ds, "EquiposFaciles");
                //            string Liga = ds.Tables["EquiposFaciles"].Rows[0][0].ToString();
                //            this.Liga.Text = Liga;

                /////////////////////////////////////////////////////////////////////////////////////////
                //            OleDbCommand Anio_Fundacion;
                //                 string sqlf = "SELECT Anio_Fundacion FROM EquiposFaciles WHERE Id = " + IdEquipo + "";

                //         Anio_Fundacion = new OleDbCommand(sqlf, BaseDeDatosProyecto);
                //            OleDbDataAdapter daf = new OleDbDataAdapter(Anio_Fundacion);
                //            DataSet dsf = new DataSet();
                //            daf.Fill(dsf, "EquiposFaciles");
                //            string AnioFundacion = dsf.Tables["EquiposFaciles"].Rows[0][0].ToString();
                //            Fundacion.Text = AnioFundacion;
                //            //////////////////////////////////////////////////////////////////////////////////////

                //            OleDbCommand Titulod;
                //            string sqlt = "SELECT Titulos FROM EquiposFaciles WHERE Id = " + IdEquipo + "";

                //            Titulod = new OleDbCommand(sqlt, BaseDeDatosProyecto);
                //            OleDbDataAdapter dat = new OleDbDataAdapter(Titulod);
                //            DataSet dset = new DataSet();
                //            dat.Fill(dset, "EquiposFaciles");
                //            string Titulos = dset.Tables["EquiposFaciles"].Rows[0][0].ToString();
                //            Titulo.Text = Titulos;





                //OleDbCommand comando = new OleDbCommand(comprobacion, conexion);
                //OleDbDataReader lector;
                //lector = comando.ExecuteReader();
                //        Boolean existencia = lector.HasRows;
                //        if (existencia)
                //        {

                //            MessageBox.Show("El dato existe");

                //        }

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
            if (Fundacion.Visible)
            {
                Titulos.Visible = true;
            }
            else
            {
                Fundacion.Visible = true;
            }

            if (Titulos.Visible)
            {
                Liga.Text = Convert.ToString(ds.Tables[0].Rows[1].ItemArray[2]);
                Fundacion.Text = Convert.ToString(ds.Tables[0].Rows[1].ItemArray[3]);
                Titulos.Text = Convert.ToString(ds.Tables[0].Rows[1].ItemArray[4]);
            }
        }



        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
