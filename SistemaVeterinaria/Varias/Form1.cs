//Diseñado y programado por Cristopher Pèrez V. 18.973.714-9
using SistemaVeterinaria.Administrador;
using SistemaVeterinaria.Clases;
using SistemaVeterinaria.Secretaria;
using SistemaVeterinaria.Varias;
using SistemaVeterinaria.Veterinario;
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

namespace SistemaVeterinaria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //BOTON INGRESAR
        private void BotonIngresar_Click(object sender, EventArgs e)
        {
            //envio datos
            Usuario userLogeado = new Usuario();
            ConsultaGeneral con = new ConsultaGeneral();

            //Validad casillas en blanco
            if (CajaID.Text == "" || CajaClave.Text == "")
            {
                MessageBox.Show("Rellene casillas.");
            }else{
                if (con.VerificarUsuarioExiste(CajaID.Text, Convert.ToInt32(CajaClave.Text)))
                {
                    //almaceno los datos en la clase "Usuarios"
                    ArrayList us = new ArrayList();
                    us = con.ObtenerRangoUsuario(CajaID.Text, Convert.ToInt32(CajaClave.Text));

                    userLogeado.SetRolUsuario(us[0].ToString());

                    switch (userLogeado.GetRolUsuario())
                    {
                        case "ADMINISTRADOR":
                            this.Hide();
                            PrincipalA prina = new PrincipalA(CajaID.Text, CajaClave.Text);
                            prina.ShowDialog();
                            this.Show();
                            break;
                        case "VETERINARIO":
                            this.Hide();
                            PrincipalV prinv = new PrincipalV(CajaID.Text, CajaClave.Text);
                            prinv.ShowDialog();
                            this.Show();
                            break;
                        case "SECRETARIA":
                            this.Hide();
                            PrincipalS prins = new PrincipalS(CajaID.Text, CajaClave.Text);
                            prins.ShowDialog();
                            this.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe.");
                }
                CajaClave.Text = "";
                CajaID.Text = "";
            }
            
        }

        //BOTON SALIR
        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //SOLO NUMEROS
        private void CajaClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CONTROL DE CASILLA. SOLO NUMEROS
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
