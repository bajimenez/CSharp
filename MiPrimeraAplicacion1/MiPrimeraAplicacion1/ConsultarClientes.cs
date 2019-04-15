using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MiLibreria;

namespace MiPrimeraAplicacion1
{
    public partial class ConsultarClientes : Form
    {

        SqlConnection con;
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder cmbl;



        public ConsultarClientes()
        {
            InitializeComponent();
        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {
            try {
                con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-MQ0SN5H\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True";
                con.Open();
                adap = new SqlDataAdapter("select * from Articulo", con);
                ds = new DataSet();
                adap.Fill(ds,"detalles");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error) { MessageBox.Show(error.Message); }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            try {
                cmbl = new SqlCommandBuilder(adap);
                adap.Update(ds,"detalles");
                MessageBox.Show("informacion actualizada");
                
            }
            catch (Exception error ) {
                MessageBox.Show(error.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds= Utilidades.ejecutarConsulta("select * from Articulo where Nom_pro like ('%" + textBox1.Text + "%')");
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string dato = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString();
            var num = dataGridView1.Rows[0].Cells.Count;
            MessageBox.Show(""+ num);
        }
    }
}
