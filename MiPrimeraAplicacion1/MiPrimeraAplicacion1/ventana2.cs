using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicacion1
{
    public partial class ventana2 : Form
    {
        public ventana2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string seleccion;
            if (checkBox1.Checked==true) {
                cont ++;
            }
            if (checkBox2.Checked == true)
            {
                cont ++;
            }
            if (radioButton1.Checked == true)
            {
                seleccion = "Credit Card";
            }
            else {
                seleccion = "PayPal";

            }

            MessageBox.Show("Ha selecccionado:" + cont + " y el metodo de pago es: " + seleccion);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }
    }
}
