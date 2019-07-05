//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using SistemaVeterinaria.Clases;
using SistemaVeterinaria.Clases_Normales;
using SistemaVeterinaria.Clases_SQL;
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

namespace SistemaVeterinaria.Veterinario
{
    public partial class PrincipalV : Form
    {
        public PrincipalV()
        {
            InitializeComponent();
        }

        //ATRIBUTOS
        private int IdMascota = 0;
        private String NombreMascota = "";

        //CONSTRUCTOR
        public PrincipalV(String cod, String cla)
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

        //LOAD
        private void PrincipalV_Load(object sender, EventArgs e)
        {
            BotonReceta.Enabled = false;
            BotonVerRegistroVacunacion.Enabled = false;
        }

        //BOTON CREAR NUEVA RECETA
        private void BotonReceta_Click(object sender, EventArgs e)
        {
            Receta rec = new Receta(IdMascota, NombreMascota);
            rec.ShowDialog();
        }

        //BOTON REGISTROS VACUNAS
        private void BotonVerRegistroVacunacion_Click(object sender, EventArgs e)
        {
            RegistroVacunas reg = new RegistroVacunas(IdMascota, NombreMascota);
            reg.ShowDialog();
        }

        //BOTON PARA VER LAS CONSULTAS Y RELLENARLAS
        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            RegistroConsultas reg = new RegistroConsultas();

            if (reg.ShowDialog() == DialogResult.OK)
            {
                NombreMascota = reg.NombreMascota; //lee la propiedad
                IdMascota = reg.IdMascota; //lee la propiedad

                //Verifico que los datos obetnidos corresponden a una mascota
                ConsultasVeterinario conse = new ConsultasVeterinario();

                if (conse.VerificarMascotaVeterinario(NombreMascota, IdMascota))
                {
                        BotonReceta.Enabled = true;
                        BotonVerRegistroVacunacion.Enabled = true;
                }
                else
                {
                    BotonReceta.Enabled = false;
                    BotonVerRegistroVacunacion.Enabled = false;
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
