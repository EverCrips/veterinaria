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
    public partial class NuevaVacuna : Form
    {
        public NuevaVacuna()
        {
            InitializeComponent();
        }
        //CONSTRUCTOR
        public NuevaVacuna(int codid, String nome)
        {
            InitializeComponent();
            //Verifico que exista el registro
            ConsultasVeterinario conv = new ConsultasVeterinario();
            if (conv.VerificarMascotaVeterinario(nome, codid))
            {
                CajaIdMascota.Text = codid.ToString();
                CajaNombreMascota.Text = nome;
            }
            else
            {
                MessageBox.Show("No existe registro de mascota. Intente nuevamente.");
                this.Close();
            }
        }

        //BOTON CREAR NUEVA VACUNA
        private void BotonProgramarVacuna_Click(object sender, EventArgs e)
        {
            if(CajaIdMascota.Text =="" || CajaNombreMascota.Text =="" || CajaOtrosVacuna.Text =="" || CajaNombreVacuna.Text =="")
            {
                MessageBox.Show("Rellen las casillas antes de proceder.");
            }
            else
            {
                ConsultasVeterinario conv = new ConsultasVeterinario();
                String fech = CajaFechaProgramadaVacuna.Value.ToString("d-MMM-yyyy hh:mm:ss");

                if (conv.RegistrarVacunaVeterinario(CajaNombreVacuna.Text, fech, CajaOtrosVacuna.Text, Convert.ToInt32(CajaIdMascota.Text)))
                {
                    MessageBox.Show("Se ha creado una nueva vacuna para la mascota.");
                    this.Close();
                }
                else
                {
                     MessageBox.Show("Ha ocurrido un error. Intente nuevamente.");
                }
            }
        }

        //BOTON ATRAS
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
