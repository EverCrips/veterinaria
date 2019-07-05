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

namespace SistemaVeterinaria.Veterinario
{
    public partial class RegistroVacunas : Form
    {
        public RegistroVacunas()
        {
            InitializeComponent();
        }
        
        //ATRIBUTOS
        public int idmasc = 0;
        public String nommas = "";

        //CONSTRUCTOR
        public RegistroVacunas(int id, String nombre)
        {
            InitializeComponent();
            idmasc = id;
            nommas = nombre;
        }

        //LOAD
        private void RegistroVacunas_Load(object sender, EventArgs e)
        {
            ConsultasVeterinario conv = new ConsultasVeterinario();
            conv.MostrarRegistroVacunasProgramadasVeterinario(MostrarDatos, idmasc);

            CajaVerRegistroVacunas.Items.Add("PROGRAMADAS");
            CajaVerRegistroVacunas.Items.Add("REALIZADAS");
        }

        //BOTON CREAR NUEVA VACUNA
        private void BotonNuevaVacuna_Click(object sender, EventArgs e)
        {
            NuevaVacuna nv = new NuevaVacuna(idmasc, nommas);
            nv.ShowDialog();
            ConsultasVeterinario conv = new ConsultasVeterinario();
            conv.MostrarRegistroVacunasProgramadasVeterinario(MostrarDatos, idmasc);
        }

        //CAMBIAR VISUALIZACION REGISTRO VACUNAS
        private void CajaVerRegistroVacunas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultasVeterinario conv = new ConsultasVeterinario();
            switch(CajaVerRegistroVacunas.Text){
                case "PROGRAMADAS":
                    conv.MostrarRegistroVacunasProgramadasVeterinario(MostrarDatos, idmasc);
                    break;
                case "REALIZADAS":
                    conv.MostrarRegistroVacunasRealizadasVeterinario(MostrarDatos, idmasc);
                    break;
            }
        }

        //BOTON CAMBIAR ESTADO DE UNA VACUNA PROGRAMADA A UNA REALIZADA
        private void BotonCambiarEstadoVacuna_Click(object sender, EventArgs e)
        {
            if(CajaIdVacuna.Text=="")
            {
                MessageBox.Show("Ingrese una id de una vacuna a cambiar.");
            }
            else
            {
                ConsultasVeterinario conv = new ConsultasVeterinario();
                //Exista la vacuna
                if(conv.VerificarVacunaVeterinario(Convert.ToInt32(CajaIdVacuna.Text)))
                {
                    if(conv.ModificarEstadoVacunaVeterinario(Convert.ToInt32(CajaIdVacuna.Text))){
                        MessageBox.Show("Se ha realizado el cambio. Vacuna realizada.");
                        CajaIdVacuna.Text = "";
                        conv.MostrarRegistroVacunasProgramadasVeterinario(MostrarDatos, idmasc);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error. Intenten nuevamente.");
                        CajaIdVacuna.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("No existe dicha vacuna. Intente nuevamente.");
                    CajaIdVacuna.Text = "";
                }
            }
        }

        //BOTON ATRAS
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //SOLO NUMEROS
        private void CajaIdVacuna_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CONTROL DE CASILLA. SOLO NUMEROS
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
