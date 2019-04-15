using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //para poder utilizar las variables de conexiones
using MiLibreria; //para utilizar la librerira ya creada con las funciones y utilidades sql 

namespace MiPrimeraAplicacion1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public static string codigo = "";

        private void button1_Click(object sender, EventArgs e)
        {
            //el 'this' hace referencia a la instanacia en la que estoy trabajando , en este caso la clase form1
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            /*if (txtUsuario.Text == "bra" && txtPass.Text=="123") {
                MessageBox.Show("correcto");

            }
            else{
                MessageBox.Show("incorrecto");
                txtUsuario.Text = " ";
                txtPass.Text =" ";
            }*/
            /*
            this.Hide();
            ventana2 nuevaVentana = new ventana2();
            nuevaVentana.Show();*/
            //Sin usar libreria
            /*
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-MQ0SN5H\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
                conexion.Open();
                MessageBox.Show("Se ha conectado a la base");
            }
            catch(Exception error) {
                MessageBox.Show("Se ha producido un error");
            }
            */
            //Uitlizando libreria

            try {
                string consulta = ("SELECT * FROM USUARIO WHERE acount ='"+Convert.ToString(txtUsuario.Text)+"' AND password='"+ Convert.ToString(txtPass.Text)+"'");
                
               DataSet DS= Utilidades.ejecutarConsulta(consulta);
                //para recorrer el dataset
                string resultadoConsulta = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
                codigo = DS.Tables[0].Rows[0]["id_usuario"].ToString();
                if (Convert.ToBoolean(DS.Tables[0].Rows[0]["status"]))
                {
                    this.Hide();
                    FormAdmin ventanaAdmin = new FormAdmin();
                    ventanaAdmin.Show();
                }
                else {
                    this.Close();
                    FormUser ventanaUsuario = new FormUser();
                    ventanaUsuario.Show();

                }
            }
            catch (Exception error) {
                MessageBox.Show("usuario o contrasenia incorrecta" + error.Message);
            }
        }
    }
}
