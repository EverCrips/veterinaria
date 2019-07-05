//Diseñado y programado por Cristopher Pèrez V. 18.973.714-9
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

namespace SistemaVeterinaria.Administrador
{
    public partial class PrincipalA : Form
    {
        public PrincipalA()
        {
            InitializeComponent();
        }
      
        //ATRIBUTOS DE LA CLASE
        public string codi = "", clas = "";

        //CONSTRUCTOR DE LA CLASE
        public PrincipalA(String cod, String cla)
        {
            InitializeComponent();

            codi = cod;
            clas = cla;
            Datos();
        }
 
        //BOTON CREAR USUARIO
        private void BotonCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuarioNuevo cre = new CrearUsuarioNuevo();
            cre.ShowDialog();
            Datos();
        }

        //BOTON VER USUARIOS
        private void BotonVerEliminarUsuario_Click(object sender, EventArgs e)
        {
            Ver_EliminarUsuario ver = new Ver_EliminarUsuario();
            ver.ShowDialog();
            Datos();
        }

        //BOTON ATRAS
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FUNCION OBTENER LOS DATOS DEL USUARIO PRESENTE
        public void Datos()
        {
            //Obtengo datos del usuario ya que existe
            ConsultaGeneral consu = new ConsultaGeneral();
            Usuario us = new Usuario();

            ArrayList arre = new ArrayList();
            arre = consu.ObtenerDatosUsuario(codi, Convert.ToInt32(clas));

            //Almaceno en la clase para utilizar a futuro
            us.SetRunUsuario(arre[0].ToString());
            us.SetNombreUsuario(arre[1].ToString());
            us.SetApellidosUsuario(arre[2].ToString());
            us.SetFonoUsuario(arre[3].ToString());
            us.SetCelularUsuario(arre[4].ToString());
            us.SetDireccionUsuario(arre[5].ToString());
            us.SetCorreoUsuario(arre[6].ToString());
            us.SetCodigoUsuario(codi);

            TextoUsuario.Text = "Usuario: " + us.GetNombreUsuario() + " " + us.GetApellidoUsuario();
        }
    }
}
