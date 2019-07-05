//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Clases_Normales
{
    class Cliente
    {
        //Atributos
        private static String rut_cliente = "", nombre_cliente = "", apellidos_cliente = "", fono_cliente = "",
                celular_cliente = "", direccion_cliente = "";
        private static int id_cliente = 0;

        //Metodos SET
        public void SetRutCliente(String rut)
        {
            rut_cliente = rut;
        }
        public void SetNombreCliente(String nombr)
        {
            nombre_cliente = nombr;
        }
        public void SetApellidosCliente(String apel)
        {
            apellidos_cliente = apel;
        }
        public void SetFonoCliente(String fon)
        {
            fono_cliente = fon;
        }
        public void SetCelularCliente(String cel)
        {
            celular_cliente = cel;
        }
        public void SetDireccionCliente(String direc)
        {
            direccion_cliente = direc;
        }
        public void SetIdCliente(int id)
        {
            id_cliente = id;
        }
        //Metodos GET
        public String GetRutCliente()
        {
            return rut_cliente;
        }
        public String GetNombreCliente()
        {
            return nombre_cliente;
        }
        public String GetApellidoCliente()
        {
            return apellidos_cliente;
        }
        public String GetFonoCliente()
        {
            return fono_cliente;
        }
        public String GetCelularCliente()
        {
            return celular_cliente;
        }
        public String GetDireccionCliente()
        {
            return direccion_cliente;
        }
        public int GetIdCliente()
        {
            return id_cliente;
        }
    }
}
