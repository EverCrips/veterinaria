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
    public partial class VerConsultas : Form
    {
        public VerConsultas()
        {
            InitializeComponent();
        }

        //LOAD
        private void VerConsultas_Load(object sender, EventArgs e)
        {
            CajaVerConsultas.Items.Add("EN ESPERA");
            CajaVerConsultas.Items.Add("REALIZADAS");
            ConsultasSecretaria conse = new ConsultasSecretaria();
            conse.MostrarConsultasEnEsperaSecretaria(MostrarDatos);
        }

        //BOTON CAMBIAR ESTADO DE UNA CONSULTA A REALIZADA
        private void BotonCambiar_Click(object sender, EventArgs e)
        {
            if (CajaCambiarEstadoConsulta.Text == "")
            {
                MessageBox.Show("Ingrese una id para cambiar una cita.");
            }
            else
            {
                ConsultasSecretaria conse = new ConsultasSecretaria();
                if (conse.ModificarEstadoConsultaSecretaria(Convert.ToInt32(CajaCambiarEstadoConsulta.Text)))
                {
                    MessageBox.Show("Estado de cita cambiado.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error. Intente nuevamente.");
                }
                CajaCambiarEstadoConsulta.Text = "";
                conse.MostrarConsultasEnEsperaSecretaria(MostrarDatos);
            }
        }

        //CAMBIAR VISUALIZACION CONSULTAS
        private void CajaVerConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultasSecretaria conse = new ConsultasSecretaria();
            switch (CajaVerConsultas.Text)
            {
                case "EN ESPERA":
                    conse.MostrarConsultasEnEsperaSecretaria(MostrarDatos);
                    break;
                case "REALIZADAS":
                    conse.MostrarConsultasRealizadasSecretaria(MostrarDatos);
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
