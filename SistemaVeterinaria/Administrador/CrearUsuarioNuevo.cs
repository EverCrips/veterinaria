//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using SistemaVeterinaria.Clases;
using System;
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
    public partial class CrearUsuarioNuevo : Form
    {
        public CrearUsuarioNuevo()
        {
            InitializeComponent();
        }
        //LOAD
        private void CrearUsuarioNuevo_Load(object sender, EventArgs e)
        {
            //Opciones ComboBox
            CajaRol.Items.Add("ADMINISTRADOR");
            CajaRol.Items.Add("VETERINARIO");
            CajaRol.Items.Add("SECRETARIA");
        }
        
        //BOTON INGRESAR NUEVO USUARIO
        private void BotonInsertar_Click(object sender, EventArgs e)
        {
            //Control de casillas vacias
            if(CajaCodigo.Text =="" || CajaNombre.Text =="" || CajaApellidos.Text =="" || CajaRun.Text ==""
                || CajaCelular.Text =="" || CajaDireccion.Text =="" || CajaMail.Text =="" ||CajaRol.Text =="")
            {
                    MessageBox.Show("Rellene casillas.");
            }
            else
            {
                Usuario use = new Usuario();
                ConsultasAdministrador conad = new ConsultasAdministrador();

                //Almaceno en la clase usuario las casillas para luego registrarlo en la funcion sql
                use.SetCodigoUsuario(CajaCodigo.Text);
                use.SetNombreUsuario(CajaNombre.Text);
                use.SetApellidosUsuario(CajaApellidos.Text);
                use.SetRunUsuario(CajaRun.Text);
                use.SetFonoUsuario(CajaFono.Text);
                use.SetCelularUsuario(CajaCelular.Text);
                use.SetDireccionUsuario(CajaDireccion.Text);
                use.SetCorreoUsuario(CajaMail.Text);
                switch (CajaRol.Text)
                {
                    case "ADMINISTRADOR":
                        use.SetIDRolUsuario(1);
                        break;
                    case "VETERINARIO":
                        use.SetIDRolUsuario(2);
                        break;
                    case "SECRETARIA":
                        use.SetIDRolUsuario(3);
                        break;
                }

                if (conad.RegistrarUsuarioAdmin(use))
                {
                    MessageBox.Show("Se ha registrado un nuevo usuario de forma correcta.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar registrar un usuario.");
                }
                //Limpio casillas
                limp();
            }
        }
        
        //BOTON LIMPIAR
        private void BotonLimpiarCasillas_Click(object sender, EventArgs e)
        {
            limp();
        }

        //BOTON ATRAS
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FUNCION LIMPIAR
        private void limp()
        {
            CajaCodigo.Text = "";
            CajaNombre.Text = "";
            CajaApellidos.Text = "";
            CajaFono.Text = "";
            CajaCelular.Text = "";
            CajaDireccion.Text = "";
            CajaMail.Text = "";
            CajaRol.Text = "";
            CajaRol.SelectedIndex = -1;
            CajaRun.Text = "";
        }
    }
}
