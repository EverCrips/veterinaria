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

namespace SistemaVeterinaria.Veterinario
{
    public partial class RegistroConsultas : Form
    {
        public RegistroConsultas()
        {
            InitializeComponent();
        }
        //ATRIBUTOS
        public String NombreMascota { get; set; }
        public int IdMascota { get; set; }

        //LOAD
        private void RegistroConsultas_Load(object sender, EventArgs e)
        {
            ConsultasVeterinario conv = new ConsultasVeterinario();
            conv.MostrarConsultasEnEsperaVeterinario(MostrarDatos);
        }

        //BOTON OBTENER DATOS DE UNA CONSULTA
        private void button1_Click(object sender, EventArgs e)
        {
            ConsultasVeterinario conv = new ConsultasVeterinario();

            if(CajaCodigoConsulta.Text ==""){
                MessageBox.Show("Rellene el campo para obtener los datos de una consulta");
            }
            else
            {
                if(conv.VerificarConsultaVeterinario(Convert.ToInt32(CajaCodigoConsulta.Text))){
                    //Consulta si existe, obtener los datos
                    ArrayList arr = new ArrayList();

                    arr = conv.ObtenerDatosConsultaVeterinario(Convert.ToInt32(CajaCodigoConsulta.Text));
                    CajaFecha.Text = arr[0].ToString();
                    CajaCodigoActual.Text = CajaCodigoConsulta.Text;

                    //retorno valores al formulario principal
                    NombreMascota = arr[2].ToString();
                    IdMascota = Convert.ToInt32(arr[1]);

                    CajaSintomas.ReadOnly = false;
                    CajaDiagnostico.ReadOnly = false;
                    CajaOtros.ReadOnly = false;
                    BotonModificar.Enabled = true;
                }else{
                    MessageBox.Show("No existe la consulta. Intente nuevamente.");
                    Limpiar();
                }
            }
        }

        //BOTON LIMPIAR
        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //BOTON MODIFICAR LA CONSULTA
        private void BotonRegistrar_Click(object sender, EventArgs e)
        {
            if(CajaCodigoActual.Text =="" || CajaFecha.Text =="" || CajaOtros.Text ==""){
                MessageBox.Show("Registre una consulta primero.");
            }
            else
            {
                ConsultasVeterinario conv = new ConsultasVeterinario();

                if(conv.ModificarConsultaVeterinario(Convert.ToInt32(CajaCodigoActual.Text), CajaSintomas.Text, CajaDiagnostico.Text, CajaOtros.Text)){
                    MessageBox.Show("Consulta modificada.");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }else{
                    MessageBox.Show("Ha ocurrido un error. Intente nuevamente.");
                    CajaOtros.Text = "";
                    CajaDiagnostico.Text = "";
                    CajaSintomas.Text = "";
                }
            }
        }

        //BOTON MODIFICAR LOS DATOS DE LA MASCOTA DE DICHA CONSULTA
        private void BotonModificar_Click(object sender, EventArgs e)
        {
            ModificarMascota mod = new ModificarMascota(IdMascota, NombreMascota);
            mod.ShowDialog();
        }

        //BOTON ATRAS   
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FUNCION LIMPIAR CASILLAS
        public void Limpiar()
        {
            CajaCodigoConsulta.Text = "";
            CajaSintomas.ReadOnly = true;
            CajaSintomas.Text = "";
            CajaDiagnostico.ReadOnly = true;
            CajaDiagnostico.Text = "";
            CajaCodigoActual.ReadOnly = true;
            CajaCodigoActual.Text = "";
            CajaFecha.ReadOnly = true;
            CajaFecha.Text = "";
            CajaOtros.ReadOnly = true;
            CajaOtros.Text = "";
            BotonModificar.Enabled = false;
        }

        //SOLO NUMEROS
        private void CajaCodigoConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CONTROL DE CASILLA. SOLO NUMEROS
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }   
    }
}
