//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using SistemaVeterinaria.Clases_Normales;
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
    public partial class ModificarMascota : Form
    {
        public ModificarMascota()
        {
            InitializeComponent();
        }

        //ATRIBUTOS
        private Mascota masc = new Mascota();

        //CONSTRUCTOR
        public ModificarMascota(int codi, String nombr)
        {
            InitializeComponent();
            ConsultasVeterinario conv = new ConsultasVeterinario();
            if (conv.VerificarMascotaVeterinario(nombr, codi))
            {
                //Existe y los datos corresponde. Obtengo los datos y los almaceno en las casillas
                ArrayList arres = new ArrayList();
                arres = conv.ObtenerDatosMascotaVeterinario(codi, nombr);

                //Almaceno en la clase mascota
                masc.SetIdMascota(codi);
                masc.SetNombreMascota(nombr);
                masc.SetEdadMascota(Convert.ToInt32(arres[0]));
                masc.SetPesoMascota(Convert.ToDouble(arres[1]));
                masc.SetEstaturaMascota(Convert.ToDouble(arres[2]));
                masc.SetRazaMascota(arres[3].ToString());
                masc.SetObversacionesMascota(arres[4].ToString());
                masc.SetIdCategoriaMascota(Convert.ToInt32(arres[5]));
                masc.SetNombreCliente(arres[6].ToString());

                CajaEdadMascota.Text = masc.GetEdadMascota().ToString();
                CajaEstaturaMascota.Text = masc.GetEstaturaMascota().ToString();
                CajaPesoMascota.Text = masc.GetPesoMascota().ToString();
                CajaObservaciones.Text = masc.GetObservacionesMascota();
                CajaRazaMascota.Text = masc.GetRazaMascota();

                CajaEdadMascota.Enabled = true;
                CajaEdadMascota.ReadOnly = false;
                CajaRazaMascota.Enabled = true;
                CajaRazaMascota.ReadOnly = false;
                CajaPesoMascota.Enabled = true;
                CajaPesoMascota.ReadOnly = false;
                CajaEstaturaMascota.Enabled = true;
                CajaEstaturaMascota.ReadOnly = false;
                CajaObservaciones.Enabled = true;
                CajaObservaciones.ReadOnly = false;

                CajaNombreMascota.Text = masc.GetNombreMascota();
                CajaDueño.Text = masc.GetNombreCliente();
                switch (masc.GetIdCategoriaMascota())
                {
                    case 1:
                        CajaCategoria.Text = "ESCIÚRIDOS";
                        break;
                    case 2:
                        CajaCategoria.Text = "MÚRIDOS";
                        break;
                    case 3:
                        CajaCategoria.Text = "CRICÉTIDOS";
                        break;
                    case 4:
                        CajaCategoria.Text = "FÉLIDOS";
                        break;
                    case 5:
                        CajaCategoria.Text = "CÁNIDOS";
                        break;
                    case 6:
                        CajaCategoria.Text = "MUSTÉLIDOS";
                        break;
                    case 7:
                        CajaCategoria.Text = "GALLINÁCEAS";
                        break;
                    case 8:
                        CajaCategoria.Text = "TESTUDÍNIDOS";
                        break;
                    case 9:
                        CajaCategoria.Text = "TITÓNIDOS";
                        break;
                }

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error. Intente nuevamente.");
            }
        }

        //BOTON MODIFICAR LOS DATOS DE UNA MASCOTA
        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if(CajaNombreMascota.Text =="" || CajaDueño.Text =="" || CajaCategoria.Text ==""){
                MessageBox.Show("Ha ocurrido un error. Intente nuevamente.");
            }else{
                ConsultasVeterinario conv = new ConsultasVeterinario();

                masc.SetEdadMascota(Convert.ToInt32(CajaEdadMascota.Text));
                masc.SetEstaturaMascota(Convert.ToDouble(CajaEstaturaMascota.Text));
                masc.SetPesoMascota(Convert.ToDouble(CajaPesoMascota.Text));
                masc.SetObversacionesMascota(CajaObservaciones.Text);
                masc.SetRazaMascota(CajaRazaMascota.Text);

                //Modifico los datos de la mascota
                if(conv.ModificarMascotaVeterinario(masc)){
                    MessageBox.Show("Datos modificados correctamente.");
                    this.Close();
                }else{
                    MessageBox.Show("No se ha podido modificar los datos. Intenten nuevamente.");
                    this.Close();
                }
            }
        }

        //BOTON ATRAS   
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //SOLO NUMEROS
        private void CajaEdadMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CONTROL DE CASILLA. SOLO NUMEROS
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
