using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loggin
{
    public partial class Form1 : Form
    {
        usuario usuarios = new usuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txbUsuario.Text;
            string password = txbContraseña.Text;


            var lista = usuarios.ObtenerUsuario();

            var validar = lista.FirstOrDefault(u => u.NameUsuario == user && u.Contraseña == password);
            if (validar != null)
            {
                this.Hide();
                inicio inicio = new inicio();
                inicio.Show();
            }
            else
            {

                MessageBox.Show("Error critico");
            }
        }
    }
}
