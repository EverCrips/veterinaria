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

namespace SistemaVeterinaria.Secretaria
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        //LOAD
        private void NuevoCliente_Load(object sender, EventArgs e)
        {
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

        //BOTON CREAR NUEVO CLIENTE CON UNA MASCOTA
        private void BotonCrearClienteNuevo_Click(object sender, EventArgs e)
        {
            //Control casillas
            if(CajaNombreCliente.Text =="" || CajaRunCliente.Text=="" || CajaApellidosCliente.Text =="" || CajaCelularCliente.Text =="" 
                || CajaDireccionCliente.Text =="" || CajaNombreMascota.Text =="")
            {
                MessageBox.Show("Rellene las casillas.");
            }
            else
            {
                //Creo un cliente en primera instancia
                Cliente cli = new Cliente();
                cli.SetRutCliente(CajaRunCliente.Text);
                cli.SetNombreCliente(CajaNombreCliente.Text);
                cli.SetApellidosCliente(CajaApellidosCliente.Text);
                cli.SetFonoCliente(CajaFonoCliente.Text);
                cli.SetCelularCliente(CajaCelularCliente.Text);
                cli.SetDireccionCliente(CajaDireccionCliente.Text);

                ConsultasSecretaria conse = new ConsultasSecretaria();
                if(conse.RegistrarClienteSecretaria(cli)){
                    //Creado el cliente, se debe crear la mascota al usuario
                    //Por defecto, la mascota solo tendrá el nombre y la categoria correspondiente (), ya que los datos como estatura, edad y resto... se los agregará el
                    //veterinario
                    
                    //Obtengo la id del cliente que se acaba de crer
                    ArrayList ares = new ArrayList();
                    ares = conse.ObtenerIdClienteSecretaria(CajaRunCliente.Text);

                    Mascota masc = new Mascota();
                    masc.SetIdCliente(Convert.ToInt32(ares[0]));
                    masc.SetNombreMascota(CajaNombreMascota.Text);
                    switch(CajaCategoriaMascota.Text){
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
                    if(conse.RegistrarMascotaSecretaria(masc))
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
