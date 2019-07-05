//Diseñado y programado por Cristopher Pèrez V. 18.973.714-9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Clases
{
    class Usuario
    {
        //Atributos
        private static String codigo_usuario="",run_usuario="", nombre_usuario="", apellidos_usuario="",
            fono_usuario="", celular_usuario="", direccion_usuario="", corre_usuario="", nombre_rol_usuario="";
        private static int id_usuario = 0, eliminado_usuario = 0, id_rol_usuario = 0, clave_usuario=0;

        //Metodos SET
        public void SetCodigoUsuario(String cod)
        {
            codigo_usuario = cod;
        }
        public void SetRunUsuario(String run)
        {
            run_usuario = run;
        }
        public void SetNombreUsuario(String nom)
        {
            nombre_usuario = nom;
        }
        public void SetApellidosUsuario(String apel)
        {
            apellidos_usuario = apel;
        }
        public void SetFonoUsuario(String fon)
        {
            fono_usuario = fon;
        }
        public void SetCelularUsuario(String cel)
        {
            celular_usuario = cel;
        }
        public void SetDireccionUsuario(String dire)
        {
            direccion_usuario = dire;
        }
        public void SetCorreoUsuario(String cor)
        {
            corre_usuario = cor;
        }
        public void SetRolUsuario(String rol)
        {
            nombre_rol_usuario = rol;
        }
        public void SetIdUsuario(int idus)
        {
            id_usuario = idus;
        }
        public void SetClaveUsuario(int clave)
        {
            clave_usuario = clave;
        }
        public void SetEliminadoUsuario(int elim)
        {
            eliminado_usuario = elim;
        }
        public void SetIDRolUsuario(int idrol)
        {
            id_rol_usuario = idrol;
        }
        //Metodos GET
        public String GetCodigoUsuario()
        {
            return codigo_usuario;
        }
        public String GetRunUsuario()
        {
            return run_usuario;
        }
        public String GetNombreUsuario()
        {
            return nombre_usuario;
        }
        public String GetApellidoUsuario()
        {
            return apellidos_usuario;
        }
        public String GetFonoUsuario()
        {
            return fono_usuario;
        }
        public String GetCelularUsuario()
        {
            return celular_usuario;
        }
        public String GetDireccionUsuario()
        {
            return direccion_usuario;
        }
        public String GetCorreoUsuario()
        {
            return corre_usuario;
        }
        public String GetRolUsuario()
        {
            return nombre_rol_usuario;
        }
        public int GetIDUsuario()
        {
            return id_usuario;
        }
        public int GetClaveUsuario()
        {
            return clave_usuario;
        }
        public int GetEliminadoUsuario()
        {
            return eliminado_usuario;
        }
        public int GetIDRolUsuario()
        {
            return id_rol_usuario;
        }

    }
}
