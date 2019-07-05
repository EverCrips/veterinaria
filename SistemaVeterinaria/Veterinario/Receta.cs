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
using word = Microsoft.Office.Interop.Word;

namespace SistemaVeterinaria.Veterinario
{
    public partial class Receta : Form
    {
        public Receta()
        {
            InitializeComponent();
        }

        //CONSTRUCTOR
        public Receta(int id, String nombre)
        {
            InitializeComponent();
            CajaIdMascota.Text = id.ToString();
            CajaNombreMascota.Text = nombre;
        }

        //BOTON CREAR RECETA NUEVA
        private void BotonCrearReceta_Click(object sender, EventArgs e)
        {
            if(CajaNombreMascota.Text =="" || CajaIdMascota.Text =="" || CajaDescripcionReceta.Text==""){
                MessageBox.Show("Rellene los campos.");
            }else{      
                //Creo la receta
                ConsultasVeterinario conv = new ConsultasVeterinario();
                if (conv.RegistrarRecetaVeterinario(CajaDescripcionReceta.Text, Convert.ToInt32(CajaIdMascota.Text)))
                {
                    MessageBox.Show("Se ha creado la receta.");
                    CajaDescripcionReceta.Text = "";
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error. Intente nuevamente.");
                    this.Close();
                }
            }
        }

        //BOTON ATRAS
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON GUARDAR EN UN ARCHIVO WORD PARA POSTERIORMENTE, IMPRIMIR
        private void BotonImprimir_Click(object sender, EventArgs e)
        {
            object ObjMiss = System.Reflection.Missing.Value;
            word.Application ObjWord = new word.Application();
            String ruta = Application.StartupPath + @"\PlantillaReceta.docx";
            object parametro = ruta;
            object nombre = "nombremascota";
            object descripcionconsulta = "descripcionreceta";
            word.Document ObjDoc = ObjWord.Documents.Add(parametro, ObjMiss);
            word.Range nom = ObjDoc.Bookmarks.get_Item(ref nombre).Range;
            nom.Text = CajaNombreMascota.Text;
            word.Range descri = ObjDoc.Bookmarks.get_Item(ref descripcionconsulta).Range;
            descri.Text = CajaDescripcionReceta.Text;

            object rango1 = nom;
            object rango2 = descri;
            ObjDoc.Bookmarks.Add("nombremascota", ref rango1);
            ObjDoc.Bookmarks.Add("descripcionreceta", ref rango2);
            ObjWord.Visible = true;
        }
    }
}
