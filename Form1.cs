using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_PROG
{
    public partial class Form1 : Form 
    {

        SqlConnection conexion = new SqlConnection ("server = DESKTOP-D8ULQLI; database = LOGIN; integrated security = true");

        public Form1()
        {
            InitializeComponent();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            
            string query = "INSERT INTO USERS (Usuarios,Contraseñas) VALUES (@usuario,@contraseña)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@usuario", txtuser.Text);
            comando.Parameters.AddWithValue("@contraseña", txtpass.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos ingresados correctamente");
        }
    }
}
/*try
{
    conexion.Open();
    MessageBox.Show("Conectado");
}
            catch (Exception)
{

    MessageBox.Show("Error");
}*/