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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }
        //ATRIBUTOS
        private int IdCliente = 0, IdMascota = 0;

        //BOTON AGREGAR CLIENTE-MASCOTA
        private void BotonIngresarCliente_Click(object sender, EventArgs e)
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

                CajaNombreMascota.Text = arreglin[2].ToString();
                CajaNombreCliente.Text = arreglin[0].ToString() + " " + arreglin[1].ToString();
            }
        }

        //BOTON REGISTRAR NUEVA CONSULTA
        private void BotonRegistrar_Click(object sender, EventArgs e)
        {
            if (CajaNombreCliente.Text == "" || CajaNombreMascota.Text == "")
            {
                MessageBox.Show("Busque o cree un usuario en primera instancia.");
            }
            else
            {
                //Creo la consulta ya con el nombre del cliente y el de la mascota

                ConsultasSecretaria conse = new ConsultasSecretaria();
                if (conse.RegistrarNuevaConsulta(IdMascota))
                {
                    MessageBox.Show("Se ha creado la consulta.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error. Intente nuevamente.");
                }

                CajaNombreMascota.Text = "";
                CajaNombreCliente.Text = "";
            }
        }

        //BOTON ATRAS
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
