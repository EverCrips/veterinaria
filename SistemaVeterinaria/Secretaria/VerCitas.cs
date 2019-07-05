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
    public partial class VerCitas : Form
    {
        public VerCitas()
        {
            InitializeComponent();
        }

        //LOAD
        private void VerCitas_Load(object sender, EventArgs e)
        {
            CajaVerCitas.Items.Add("EN ESPERA");
            CajaVerCitas.Items.Add("REALIZADAS");
            ConsultasSecretaria conse = new ConsultasSecretaria();
            conse.MostrarCitasEnEsperaSecretaria(MostrarDatos);
        }

        //BOTON CAMBIAR ESTADO DE UNA CITA A REALIZADA
        private void BotonCambiar_Click(object sender, EventArgs e)
        {
            if(CajaCambiarEstadoCita.Text ==""){
                MessageBox.Show("Ingrese una id para cambiar una cita.");
            }
            else
            {
                ConsultasSecretaria conse = new ConsultasSecretaria();
                if (conse.ModificarEstadoCitaSecretaria(Convert.ToInt32(CajaCambiarEstadoCita.Text)))
                {
                    MessageBox.Show("Estado de cita cambiado.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error. Intente nuevamente.");
                }
                CajaCambiarEstadoCita.Text = "";
                conse.MostrarCitasEnEsperaSecretaria(MostrarDatos);
            }
        }

        //CAMBIAR VISUALIZACION DE CITAS
        private void CajaVerCitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultasSecretaria conse = new ConsultasSecretaria();
            switch (CajaVerCitas.Text)
            {
                case "EN ESPERA":
                    conse.MostrarCitasEnEsperaSecretaria(MostrarDatos);
                    break;
                case "REALIZADAS":
                    conse.MostrarCitasRealizadasSecretaria(MostrarDatos);
                    break;
            }
        }

        //BOTON ATRAS
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //SOLO NUMEROS
        private void CajaCambiarEstadoCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CONTROL DE CASILLA. SOLO NUMEROS
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        } 
    }
}
