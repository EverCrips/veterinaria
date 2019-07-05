//Diseñado y programado por Cristopher Pérez V. !8.973.714-9
using SistemaVeterinaria.Clases;
using SistemaVeterinaria.Varias;
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
    public partial class PrincipalS : Form
    {
        public PrincipalS()
        {
            InitializeComponent();
        }

        //CONSTRUCTOR
        public PrincipalS(String cod, String cla)
        {
            InitializeComponent();

            //Obtengo datos del usuario ya que existe
            ConsultaGeneral consu = new ConsultaGeneral();
            Usuario us = new Usuario();

            ArrayList arre = new ArrayList();
            arre = consu.ObtenerDatosUsuario(cod, Convert.ToInt32(cla));

            //Almaceno en la clase para utilizar a futuro
            us.SetRunUsuario(arre[0].ToString());
            us.SetNombreUsuario(arre[1].ToString());
            us.SetApellidosUsuario(arre[2].ToString());
            us.SetFonoUsuario(arre[3].ToString());
            us.SetCelularUsuario(arre[4].ToString());
            us.SetDireccionUsuario(arre[5].ToString());
            us.SetCorreoUsuario(arre[6].ToString());
            us.SetCodigoUsuario(cod);

            TextoUsuario.Text = "Usuario: " + us.GetNombreUsuario() + " " + us.GetApellidoUsuario();
        }

        //BOTON NUEVA CONSULTA
        private void BotonCrearConsulta_Click(object sender, EventArgs e)
        {
            Consulta con = new Consulta();
            con.ShowDialog();
        }

        //BOTON NUEVA CITA
        private void BotonCrearCita_Click(object sender, EventArgs e)
        {
            Citas cit = new Citas();
            cit.ShowDialog();
        }

        //BOTON VER CONSULTAS
        private void BotonVerConsultas_Click(object sender, EventArgs e)
        {
            VerConsultas ver = new VerConsultas();
            ver.ShowDialog();
        }

        //BOTON VER CITA
        private void BotonVerCita_Click(object sender, EventArgs e)
        {
            VerCitas ver = new VerCitas();
            ver.ShowDialog();
        }

        //BOTON ATRAS
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
