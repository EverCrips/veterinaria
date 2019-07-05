//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using SistemaVeterinaria.Clases_SQL;
using System;
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
    public partial class VerClientes : Form
    {
        public VerClientes()
        {
            InitializeComponent();
        }
        //ATRIBUTOS
        public int IdCliente { get; set; }
        public int IdMascota { get; set; }

        //LOAD
        private void VerClientes_Load(object sender, EventArgs e)
        {
            ConsultasSecretaria conse = new ConsultasSecretaria();
            conse.MostraDatosClientesSecretaria(MostrarDatos);
        }

        //BOTON SELECCIONAR CLIENTE-MASCOTA
        private void BotonSeleccionarCliente_Click(object sender, EventArgs e)
        {
            
            ConsultasSecretaria conse = new ConsultasSecretaria();
            if(CajaIdCliente.Text =="" || CajaIdMascota.Text ==""){
                MessageBox.Show("Rellene casillas para seleccionar mascota-cliente.");
            }
            else
            {
                //Compruebo que la id del cliente y la mascota existen
                if (conse.VerificarClienteMascota(Convert.ToInt32(CajaIdMascota.Text), Convert.ToInt32(CajaIdCliente.Text)))
                {
                    //cierra el formulario
                    IdCliente = Convert.ToInt32(CajaIdCliente.Text);
                    IdMascota = Convert.ToInt32(CajaIdMascota.Text);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No existe registro del cliente o mascota.");
                }
                
            }
            
        }

        //BOTON PARA AÑADIR OTRA MASCOTA A UN CLIENTE
        private void BotonAñadirMascota_Click(object sender, EventArgs e)
        {
            AñadirMascota an = new AñadirMascota();
            an.ShowDialog();
            ConsultasSecretaria conse = new ConsultasSecretaria();
            conse.MostraDatosClientesSecretaria(MostrarDatos);
        }

        //BOTON CREAR NUEVO CLIENTE
        private void BotonNuevoCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente nv = new NuevoCliente();
            nv.ShowDialog();
            ConsultasSecretaria conse = new ConsultasSecretaria();
            conse.MostraDatosClientesSecretaria(MostrarDatos);
        }

        //BOTON ATRAS
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //SOLO NUMEROS
        private void CajaIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CONTROL DE CASILLA. SOLO NUMEROS
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //SOLO NUMEROS
        private void CajaIdMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CONTROL DE CASILLA. SOLO NUMEROS
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
