//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using SistemaVeterinaria.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVeterinaria.Administrador
{
    class ConsultasAdministrador : Conexion
    {
        //rescatar tabla
        DataTable dt;
        //obetner tabla
        SqlDataAdapter DA;

        /*********************************TRABAJADORES*********************************/
        //Crear
        public Boolean RegistrarUsuarioAdmin(Usuario use)
        {
            SqlCommand insert;
            use = new Usuario();
            Boolean exito = false;
            try
            {
                //Por defecto la clave será 12345 y estará disponible el usuario
                String comando = "insert into USUARIO (eliminado_logico, codigo_usuario, clave_usuario, " +
                                    "rut_usuario, nombre_usuario, apellidos_usuario, fono_usuario, cel_usuario, " +
                                        "direccion_usuario, correo_usuario, id_rol_usuario) " +
                                            "values(1, @codigo, 12345, @rut, @nombre, @apellidos, @fono, @celular, @direccion," +
                                                "@mail, @idrol)";

                insert = new SqlCommand(comando, con);

                insert.Parameters.Add("@codigo", System.Data.SqlDbType.Char, 10).Value = use.GetCodigoUsuario();
                insert.Parameters.Add("@rut", System.Data.SqlDbType.VarChar, 13).Value = use.GetRunUsuario();
                insert.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar, 40).Value = use.GetNombreUsuario();
                insert.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar, 50).Value = use.GetApellidoUsuario();
                insert.Parameters.Add("@fono", System.Data.SqlDbType.VarChar, 13).Value = use.GetFonoUsuario();
                insert.Parameters.Add("@celular", System.Data.SqlDbType.Char, 12).Value = use.GetCelularUsuario();
                insert.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar, 60).Value = use.GetDireccionUsuario();
                insert.Parameters.Add("@mail", System.Data.SqlDbType.VarChar, 100).Value = use.GetCorreoUsuario();
                insert.Parameters.Add("@idrol", System.Data.SqlDbType.Int).Value = use.GetIDRolUsuario();

                if (insert.ExecuteNonQuery() == 1)
                {
                    exito = true;
                }
                else
                {
                    exito = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar registrar un nuevo usuario... " + ex);
                exito = false;
            }
            return exito;
        }

        //Verificar
        public Boolean VerificarUsuarioExisteAdmin(String codigo)
        {
            SqlCommand select;
            Boolean existe = false;

            try
            {
                Conectar();
                String comando = "select count(*) from USUARIO where codigo_usuario=@codigo and eliminado_logico=1";
                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@codigo", codigo);

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

        //Mostrar
        public void MostraDatosUsuariosAdmin(DataGridView data)
        {

            String comando = "select codigo_usuario as 'Codigo', clave_usuario as 'Clave', nombre_usuario+' '+" +
                                "apellidos_usuario as 'Nombre', rut_usuario as 'Run', fono_usuario as 'Fono'" +
                                    ", cel_usuario as 'Celular', direccion_usuario as 'Direccion',correo_usuario as 'Mail'" +
                                        ", nombre_rol as 'Rol' from USUARIO, ROL where id_rol_usuario=id_rol and eliminado_logico=1 ";
            try
            {

                DA = new SqlDataAdapter(comando, con);
                dt = new DataTable();
                DA.Fill(dt);

                data.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar llenar el datagried. " + ex);

            }

        }

        //Obtener
        public ArrayList ObtenerDatosUsuarioAdmin(String codigo)
        {
            SqlDataReader reader;
            ArrayList datosUser = new ArrayList();
            SqlCommand select;

            try
            {
                String comando = "select us.clave_usuario, us.nombre_usuario, us.apellidos_usuario, us.fono_usuario, " +
                                    "us.cel_usuario, us.direccion_usuario, us.correo_usuario from USUARIO us where codigo_usuario=@codigo " +
                                        "and eliminado_logico=1";

                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@codigo", codigo);

                reader = select.ExecuteReader();

                if (reader.Read())
                {
                    datosUser.Add(Convert.ToInt32(reader["clave_usuario"]));
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

        //Modificar
        public Boolean ModificarUsuarioAdmin(Usuario us)
        {
            SqlCommand update;
            Boolean modificar = false;
            us = new Usuario();
            try
            {
                String comando = "update USUARIO set clave_usuario=@clave, fono_usuario=@fono," +
                                    "cel_usuario=@cel, correo_usuario=@corr, direccion_usuario=@dire" +
                                        " where codigo_usuario=@codigo";
                update = new SqlCommand(comando, con);

                update.Parameters.Add("@clave", System.Data.SqlDbType.Int).Value = us.GetClaveUsuario();
                update.Parameters.Add("@fono", System.Data.SqlDbType.VarChar, 13).Value = us.GetFonoUsuario();
                update.Parameters.Add("@cel", System.Data.SqlDbType.Char, 12).Value = us.GetCelularUsuario();
                update.Parameters.Add("@corr", System.Data.SqlDbType.VarChar, 100).Value = us.GetCorreoUsuario();
                update.Parameters.Add("@dire", System.Data.SqlDbType.VarChar, 60).Value = us.GetDireccionUsuario();
                update.Parameters.Add("@codigo", System.Data.SqlDbType.Char, 10).Value = us.GetCodigoUsuario();

                if (update.ExecuteNonQuery() == 1)
                {
                    modificar = true;
                }
                else
                {
                    modificar = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar modificar al usuario... " + ex);
            }
            return modificar;
        }

        //Eliminar
        public Boolean EliminarUsuarioAdmin(String codigo)
        {
            SqlCommand update;
            Boolean eliminado = false;

            try
            {
                String comando = "update USUARIO set eliminado_logico=0 where codigo_usuario=@codigo and eliminado_logico=1";
                update = new SqlCommand(comando, con);

                update.Parameters.AddWithValue("codigo", codigo);

                if (update.ExecuteNonQuery() == 1)
                {
                    eliminado = true;
                }
                else
                {
                    eliminado = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar al usuario... " + ex);
            }
            return eliminado;
        }
    }
}
