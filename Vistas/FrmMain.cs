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
    public partial class FrmMain : Form
    {

        Inquilino oInquilino;
        Edificio oEdificio;
        Departamento oDepartamento;
        

        public FrmMain()
        {
            InitializeComponent();
            pnlAlta.Hide();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Quieres cargar los siguientes datos?";
            string titulo = "Confirmacion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, buttons);
            if (result == DialogResult.Yes)
            {
                string nombreI = txtNombreInquilino.Text;
                string apellidoI = txtApellidoInquilino.Text;
                string telefonoI = txtTelefonoInquilino.Text;
                
                oInquilino = new Inquilino(nombreI, apellidoI, telefonoI);



                string nombreE = txtNombreEdificio.Text;
                string direccionE = txtDireccionEdificio.Text;
                string administradorE = txtAdministradorEdificio.Text;
                string telefonoE = txtTelefonoEdificio.Text;


                oEdificio = new Edificio(nombreE, direccionE, administradorE, telefonoE);

                int codigoE = oEdificio.Edif_Codigo;
                string tipoD = txtTipoDepartamento.Text;
                int numeroD = Convert.ToInt32(txtNumeroDepartamento.Text);
                int pisoD = Convert.ToInt32(txtPisoDepartamento.Text);
                int ambienteD = Convert.ToInt32(txtAmbientesDepartamento.Text);
                int bathD = Convert.ToInt32(txtBathDepartamento.Text);
                string disposicionD = txtDisposicionDepartamento.Text;
                float precioD = Convert.ToSingle(txtPrecioDepartamento.Text);
                oDepartamento = new Departamento(codigoE, tipoD, numeroD, pisoD, ambienteD, bathD, disposicionD, precioD); 
            }
            else
            {

            }  
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Inquilino es: " + oInquilino.Inq_Nombre + 
                "\nEl Edificio es: " + oEdificio.Edif_Nombre + 
                "\nEl Departamento es:" + oDepartamento.Dpto_Precio);
        }



        private void altaDeEdificiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAlta.Show();
        }
    }
}
