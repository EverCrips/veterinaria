//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using SistemaVeterinaria.Clases_Normales;
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
    public partial class AñadirMascota : Form
    {
        public AñadirMascota()
        {
            InitializeComponent();
        }
        //LOAD
        private void AñadirMascota_Load(object sender, EventArgs e)
        {
            ConsultasSecretaria conse = new ConsultasSecretaria();
            conse.MostraDatosClientesSecretaria(MostrarDatos);

            CajaCategoriaMascota.Items.Add("ESCIÚRIDOS"); //Ardillas
            CajaCategoriaMascota.Items.Add("MÚRIDOS"); //Ratones, Ratas
            CajaCategoriaMascota.Items.Add("CRICÉTIDOS"); //hámsters
            CajaCategoriaMascota.Items.Add("FÉLIDOS"); //Gatos 
            CajaCategoriaMascota.Items.Add("CÁNIDOS"); // Perros, zorros
            CajaCategoriaMascota.Items.Add("MUSTÉLIDOS"); // Comadreja, Tejón
            CajaCategoriaMascota.Items.Add("GALLINÁCEAS"); // Gallos
            CajaCategoriaMascota.Items.Add("TESTUDÍNIDOS"); // Tortuga
            CajaCategoriaMascota.Items.Add("TITÓNIDOS"); // Lechuzas
        }

        //BOTON AÑADIR NUEVA MASCOTA CLIENTE
        private void BotonAñadirMascotaNuevacliente_Click(object sender, EventArgs e)
        {
            if(CajaIdCliente.Text =="" || CajaNombreMascota.Text =="" || CajaCategoriaMascota.Text ==""){
                MessageBox.Show("Rellene las casillas.");
            }
            else
            {
                ConsultasSecretaria conse = new ConsultasSecretaria();
                if (conse.VerificarClienteMascotaSoloId(Convert.ToInt32(CajaIdCliente.Text)))
                {
                    //Existe el cliente, solo basta crear la mascota con la id.
                    Mascota masc = new Mascota();
                    masc.SetIdCliente(Convert.ToInt32(CajaIdCliente.Text));
                    masc.SetNombreMascota(CajaNombreMascota.Text);
                    switch (CajaCategoriaMascota.Text)
                    {
                        case "ESCIÚRIDOS":
                            masc.SetIdCategoriaMascota(1);
                            break;
                        case "MÚRIDOS":
                            masc.SetIdCategoriaMascota(2);
                            break;
                        case "CRICÉTIDOS":
                            masc.SetIdCategoriaMascota(3);
                            break;
                        case "FÉLIDOS":
                            masc.SetIdCategoriaMascota(4);
                            break;
                        case "CÁNIDOS":
                            masc.SetIdCategoriaMascota(5);
                            break;
                        case "MUSTÉLIDOS":
                            masc.SetIdCategoriaMascota(6);
                            break;
                        case "GALLINÁCEAS":
                            masc.SetIdCategoriaMascota(7);
                            break;
                        case "TESTUDÍNIDOS":
                            masc.SetIdCategoriaMascota(8);
                            break;
                        case "TITÓNIDOS":
                            masc.SetIdCategoriaMascota(9);
                            break;
                    }
                    if (conse.RegistrarMascotaSecretaria(masc))
                    {
                        MessageBox.Show("Se ha registrado con exito el cliente y su mascota.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error. Intente nuevamente.");
                    }
        
                }
                else
                {
                    MessageBox.Show("El cliente no existe. Intente nuevamente.");
                }
                CajaIdCliente.Text = "";
                CajaCategoriaMascota.ResetText();
                CajaNombreMascota.Text = "";
            }
            
        }

        //BOTON ATRAS
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //SOLO NUMEROS
        private void CajaIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CONTROL DE CASILLA. SOLO NUMEROS
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
