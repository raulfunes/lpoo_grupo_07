using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        Usuario oUsu1 = new Usuario("admin", "123");
        Usuario oUsu2 = new Usuario("op", "101");
        Usuario oUsu3 = new Usuario("pleb", "8(");

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((oUsu1.Usu_NombreUsuario == txtUsuario.Text && oUsu1.Usu_Password == txtPassword.Text) || 
                (oUsu2.Usu_NombreUsuario == txtUsuario.Text && oUsu2.Usu_Password == txtPassword.Text) || 
                (oUsu3.Usu_NombreUsuario == txtUsuario.Text && oUsu3.Usu_Password == txtPassword.Text))
            {
                MessageBox.Show("Bienvenido " + txtUsuario.Text);
                FrmMain fMain = new FrmMain();
                fMain.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }

        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Moccasin;
        }
    }
}
