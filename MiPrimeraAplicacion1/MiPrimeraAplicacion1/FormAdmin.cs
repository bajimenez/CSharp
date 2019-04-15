using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;


namespace MiPrimeraAplicacion1
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            try {

                string consulta = "select * from Usuario where id_usuario ="+FormLogin.codigo;
                DataSet ds= Utilidades.ejecutarConsulta(consulta);
                txtNombre.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString();
                string url = "https://www.profoundry.co/wp-content/uploads/2016/04/User.jpg";
                pictureBox1.ImageLocation= url;
            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal venPrincipal = new ContenedorPrincipal();
            this.Hide();
            venPrincipal.Show();
        }
    }
}
