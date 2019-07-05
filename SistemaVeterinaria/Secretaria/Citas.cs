//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using SistemaVeterinaria.Clases_SQL;
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

namespace SistemaVeterinaria.Secretaria
{
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }
        //ATRIBUTOS
        private int IdCliente = 0, IdMascota = 0;

        //BOTON REGISTRAR UN NUEVO CLIENTE
        private void BotonIngresarCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente nuevcli = new NuevoCliente();
            nuevcli.Show();
        }

        //BOTON VER Y REGISTRAR EL NOMBRE DEL CLIENTE PARA LA CITA
        private void BotonInsertarCliente_Click(object sender, EventArgs e)
        {
            VerClientes vercli = new VerClientes();

            if (vercli.ShowDialog() == DialogResult.OK)
            {
                IdCliente = vercli.IdCliente; //lee la propiedad
                IdMascota = vercli.IdMascota; //lee la propiedad
                
                //Obtengo los datos y recojo el nombre del cliente con las id obtenidos.
                ConsultasSecretaria conse = new ConsultasSecretaria();
                ArrayList arreglin = new ArrayList();
                arreglin = conse.ObtenerNombreMascotaCliente(IdMascota, IdCliente);

                CajaNombreCliente.Text = arreglin[0].ToString() + " " + arreglin[1].ToString();
            }
        }

        //BOTON CREAR CITA
        private void BotonRegistrar_Click(object sender, EventArgs e)
        {
            if(CajaNombreCliente.Text =="" || CajaDescripcion.Text==""){
                MessageBox.Show("Busque o cree un usuario en primera instancia.");
            }
            else
            {
                //Creo la cita ya con el nombre del cliente
                String fech = CajaFecha.Value.ToString("d-MMM-yyyy hh:mm:ss");

                ConsultasSecretaria conse = new ConsultasSecretaria();
                if (conse.RegistrarNuevaCita(fech, CajaDescripcion.Text, IdCliente))
                {
                    MessageBox.Show("Se ha agendado una nueva cita.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error. Intente nuevamente.");
                }

                CajaDescripcion.Text = "";
                CajaNombreCliente.Text = "";
                CajaFecha.ResetText();
            }
        }

        //BOTON ATRAS
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
