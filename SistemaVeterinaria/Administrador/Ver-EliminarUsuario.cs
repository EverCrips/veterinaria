//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
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
    public partial class Ver_EliminarUsuario : Form
    {
        public Ver_EliminarUsuario()
        {
            InitializeComponent();
        }
        //LOAD
        private void Ver_EliminarUsuario_Load(object sender, EventArgs e)
        {
            ConsultasAdministrador conad = new ConsultasAdministrador();
            conad.MostraDatosUsuariosAdmin(MostrarDatos);
        }

        //BOTON MODIFICAR CONTRASEÑA-DIRECCION-FONO-CELUlAR-CORREO
        private void BotonModificar_Click(object sender, EventArgs e)
        {
            Modificar mod = new Modificar();
            mod.ShowDialog();
            ConsultasAdministrador conad = new ConsultasAdministrador();
            conad.MostraDatosUsuariosAdmin(MostrarDatos);            
        }

        //BOTON ELIMINAR
        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            //Casilla vacia
            if (CajaCodigoTrabajador.Text == "")
            {
                MessageBox.Show("Ingrese un codigo de trabajador a eliminar.");
            }
            else
            {
                ConsultasAdministrador conad = new ConsultasAdministrador();
                conad.EliminarUsuarioAdmin(CajaCodigoTrabajador.Text);
                conad.MostraDatosUsuariosAdmin(MostrarDatos);
            }
            CajaCodigoTrabajador.Text = "";
        }

        //BOTON ATRAS
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
