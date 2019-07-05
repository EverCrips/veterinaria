//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Clases_Normales
{
    class Mascota : Cliente
    {
        //Atributos
        private static String nombre_mascota="", raza_mascota="", observaciones_mascota="";
        private static int id_mascota = 0, edad_mascota = 0, id_categoria_mascota = 0;
        private static Double peso_mascota =0, estatura_mascota=0;

        //Metodos SET
        public void SetNombreMascota(String nom)
        {
            nombre_mascota =nom;
        }
        public void SetRazaMascota(String raz)
        {
            raza_mascota = raz;
        }
        public void SetObversacionesMascota(String obse)
        {
            observaciones_mascota = obse;
        }
        public void SetIdMascota(int idmasc)
        {
            id_mascota = idmasc;
        }
        public void SetEdadMascota(int edad)
        {
            edad_mascota = edad;
        }
        public void SetIdCategoriaMascota(int cate)
        {
            id_categoria_mascota = cate;
        }
        public void SetPesoMascota(Double peso)
        {
            peso_mascota = peso;
        }
        public void SetEstaturaMascota(Double esta)
        {
            estatura_mascota = esta;
        }
        //Metodos GET
        public String GetNombreMascota()
        {
            return nombre_mascota;
        }
        public String GetRazaMascota()
        {
            return raza_mascota;
        }
        public String GetObservacionesMascota()
        {
            return observaciones_mascota;
        }
        public int GetIdMascota()
        {
            return id_mascota;
        }
        public int GetEdadMascota()
        {
            return edad_mascota;
        }
        public int GetIdCategoriaMascota()
        {
            return id_categoria_mascota;
        }
        public Double GetPesoMascota()
        {
            return peso_mascota;
        }
        public Double GetEstaturaMascota()
        {
            return estatura_mascota;
        }
    }
}
