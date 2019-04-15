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
    public partial class MantenimientoProducto : FormMantenimiento
    {
        public MantenimientoProducto()
        {
            InitializeComponent();

        }

        private void MantenimientoProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
       
        public override void guardar()
        {
            try {
                string query = string.Format("if NOT EXISTS (SELECT {0} FROM Articulo WHERE id_pro={0}) insert into Articulo(id_pro, Nom_pro, Precio) values({0},'{1}',{2}) else update Articulo set id_pro = {0}, Nom_pro = '{1}', Precio = {2} where id_pro={0}",txtId.Text,txtNombre.Text,txtPrecio.Text);
                MessageBox.Show(query);
                Utilidades.ejecutarConsulta(query);
                MessageBox.Show("Se guardo exitosamente");

            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try {
                string query = string.Format("delete from Articulo where id_pro={0}",txtId.Text);
                Utilidades.ejecutarConsulta(query);
                MessageBox.Show("Se elimino correctamente");


            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) //Al pulsar una letra
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (Char.IsControl(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else //Para todo lo demas
            {
                e.Handled = true; //No se acepta (si pulsas cualquier otra cosa pues no se envia)
                MessageBox.Show("Solo numeros");
            }

        }
    }
}
