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
    public partial class FormMantenimiento : Form
    {
        public FormMantenimiento()
        {
            InitializeComponent();
        }

        private void FormMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultar();
        }

        public virtual void  consultar() { }
        public virtual void eliminar() { }
        public virtual void nuevo() { }
        public virtual void guardar() { }
        public virtual void salir() {
       
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
