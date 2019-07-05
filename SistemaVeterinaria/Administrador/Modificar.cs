//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using SistemaVeterinaria.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVeterinaria.Administrador
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }
        //LOAD
        private void Modificar_Load(object sender, EventArgs e)
        {
            CajaNombre.ReadOnly = true;
            CajaClave.ReadOnly = true;
            CajaFono.ReadOnly = true;
            CajaCelular.ReadOnly = true;
            CajaDireccion.ReadOnly = true;
            CajaCorreo.ReadOnly = true;
        }

        //BOTON BUSCAR UN USUARIO Y RELLENAR SUS DATOS
        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            ConsultasAdministrador conad = new ConsultasAdministrador();
            if (CajaCodigoUsuario.Text == "")
            {
                MessageBox.Show("Ingrese un codigo de usuario a modificar.");
            }
            else
            {
                if (conad.VerificarUsuarioExisteAdmin(CajaCodigoUsuario.Text))
                {
                    //Obtengo datos para mostrarlos en las casillas y poder modificar
                    ArrayList ar = new ArrayList();
                    ar = conad.ObtenerDatosUsuarioAdmin(CajaCodigoUsuario.Text);

                    CajaClave.Text = ar[0].ToString();
                    CajaNombre.Text = ar[1].ToString() + " " + ar[2].ToString();
                    CajaFono.Text = ar[3].ToString();
                    CajaCelular.Text = ar[4].ToString();
                    CajaCorreo.Text = ar[6].ToString();
                    CajaDireccion.Text = ar[5].ToString();

                    CajaCodigoUsuario.Enabled = false;
                    CajaCodigoUsuario.ReadOnly = true;
                    CajaNombre.Enabled = false;
                    CajaNombre.ReadOnly = true;

                    CajaClave.ReadOnly = false;
                    CajaCelular.ReadOnly = false;
                    CajaFono.ReadOnly = false;
                    CajaCorreo.ReadOnly = false;
                    CajaDireccion.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("Usuario no existente. Intente nuevamente.");
                }

            }

        }

        //BOTON MODIFICAR DATOS
        private void BotonModificar_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            ConsultasAdministrador conad = new ConsultasAdministrador();
            if (CajaNombre.Text == "")
            {
                MessageBox.Show("Realice una busqueda de trabajador primero.");
            }
            else
            {
                us.SetClaveUsuario(Convert.ToInt32(CajaClave.Text));
                us.SetFonoUsuario(CajaFono.Text);
                us.SetCelularUsuario(CajaCelular.Text);
                us.SetCorreoUsuario(CajaCorreo.Text);
                us.SetDireccionUsuario(CajaDireccion.Text);
                us.SetCodigoUsuario(CajaCodigoUsuario.Text);
                if (conad.ModificarUsuarioAdmin(us))
                {
                    MessageBox.Show("Se han modificado los datos satisfactoriamente.");
                }
                else
                {
                    MessageBox.Show("Intente nuevamente.");
                }
                CajaCelular.Text = "";
                CajaClave.Text = "";
                CajaCorreo.Text = "";
                CajaDireccion.Text = "";
                CajaFono.Text = "";
                CajaNombre.Text = "";
                CajaCodigoUsuario.Text = "";
            }
        }

        //BOTON ATRAS
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //SOLO NUMEROS EN EL TEXTBOX
        private void CajaClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CONTROL DE CASILLA. SOLO NUMEROS
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
