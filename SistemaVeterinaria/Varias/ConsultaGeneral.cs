//Diseñado y programado por Cristopher Pèrez V. 18.973.714-9
using SistemaVeterinaria.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVeterinaria.Varias
{
    class ConsultaGeneral : Conexion
    {
        //Metodo verificar Usuario
        public Boolean VerificarUsuarioExiste(String codigo, int clave)
        {
            SqlCommand select;
            Boolean existe = false;

            try
            {
                Conectar();
                String comando = "select count(*) from USUARIO where codigo_usuario=@codigo and clave_usuario=@clave and eliminado_logico=1";
                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@codigo", codigo);
                select.Parameters.AddWithValue("@clave", clave);

                //guardamos el valor que retorna la consulta en un entero
                int aux = Convert.ToInt32(select.ExecuteScalar());

                if (aux == 0)
                {
                    //si aux es igual a 0, es porque no existe un registro
                    existe = false;
                }
                else
                {
                    //si es distinto de 0, es porque existe un registro
                    existe = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar buscar un usuario... " + ex);
            }
            return existe;
        }

        //Método para obtener solo el rango del usuario
        public ArrayList ObtenerRangoUsuario(String codigo, int clave)
        {
            SqlDataReader reader;
            ArrayList datosUser = new ArrayList();
            SqlCommand select;

            try
            {
                String comando = "select ro.nombre_rol from USUARIO us, ROL ro where codigo_usuario=@codigo and " +
                                    "clave_usuario=@clave and eliminado_logico=1 and id_rol_usuario=id_rol";

                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@codigo", codigo);
                select.Parameters.AddWithValue("@clave", clave);

                reader = select.ExecuteReader();

                if (reader.Read())
                {
                    datosUser.Add(reader["nombre_rol"].ToString());
                }
                else
                {

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar buscar un usuario... " + ex);
            }

            return datosUser;
        }

        //Método para obtener todos los datos del usuario
        public ArrayList ObtenerDatosUsuario(String codigo, int clave)
        {
            SqlDataReader reader;
            ArrayList datosUser = new ArrayList();
            SqlCommand select;

            try
            {
                String comando = "select us.rut_usuario, us.nombre_usuario, us.apellidos_usuario, us.fono_usuario, "+
                                    "us.cel_usuario, us.direccion_usuario, us.correo_usuario from USUARIO us, ROL ro where codigo_usuario=@codigo and " +
                                        "clave_usuario=@clave and eliminado_logico=1 and id_rol_usuario=id_rol";

                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@codigo", codigo);
                select.Parameters.AddWithValue("@clave", clave);

                reader = select.ExecuteReader();

                if (reader.Read())
                {
                    datosUser.Add(reader["rut_usuario"].ToString());
                    datosUser.Add(reader["nombre_usuario"].ToString());
                    datosUser.Add(reader["apellidos_usuario"].ToString());
                    datosUser.Add(reader["fono_usuario"].ToString());
                    datosUser.Add(reader["cel_usuario"].ToString());
                    datosUser.Add(reader["direccion_usuario"].ToString());
                    datosUser.Add(reader["correo_usuario"].ToString());
                }
                else
                {

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar buscar un usuario... " + ex);
            }

            return datosUser;
        }
    }
}
