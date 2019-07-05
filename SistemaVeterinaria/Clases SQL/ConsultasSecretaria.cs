//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using SistemaVeterinaria.Clases;
using SistemaVeterinaria.Clases_Normales;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVeterinaria.Clases_SQL
{
    class ConsultasSecretaria : Conexion
    {
        //rescatar tabla
        DataTable dt;
        //obetner tabla
        SqlDataAdapter DA;

        /*********************************CLIENTES*********************************/
        //Crear
        public Boolean RegistrarClienteSecretaria(Cliente cli)
        {
            SqlCommand insert;
            cli = new Cliente();
            Boolean exito = false;
            try
            {
                String comando = "insert into CLIENTE (rut_cliente, nombre_cliente, " +
                                    "apellidos_cliente, fono_cliente, cel_cliente, direccion_cliente) " +
                                            "values(@rut, @nombre, @apellidos, @fono, @celular, @direccion)";

                insert = new SqlCommand(comando, con);

                insert.Parameters.Add("@rut", System.Data.SqlDbType.VarChar, 13).Value = cli.GetRutCliente();
                insert.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar, 50).Value = cli.GetNombreCliente();
                insert.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar, 50).Value = cli.GetApellidoCliente();
                insert.Parameters.Add("@fono", System.Data.SqlDbType.VarChar, 13).Value = cli.GetFonoCliente();
                insert.Parameters.Add("@celular", System.Data.SqlDbType.Char, 12).Value = cli.GetCelularCliente();
                insert.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar, 50).Value = cli.GetDireccionCliente();

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
                MessageBox.Show("Error al intentar registrar un nuevo cliente... " + ex);
                exito = false;
            }
            return exito;
        }

        //Verificar
        public Boolean VerificarClienteMascotaSoloId(int cod)
        {
            SqlCommand select;
            Boolean existe = false;

            try
            {
                Conectar();
                String comando = "select count(*) from CLIENTE where id_cliente=@cod";
                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@cod", cod);

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

        //Obtener
        public ArrayList ObtenerIdClienteSecretaria(String rut)
        {
            SqlDataReader reader;
            ArrayList datosUser = new ArrayList();
            SqlCommand select;

            try
            {
                String comando = "select id_cliente from CLIENTE where rut_cliente=@rut";
                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@rut", rut);

                reader = select.ExecuteReader();

                if (reader.Read())
                {
                    datosUser.Add(Convert.ToInt32(reader["id_cliente"]));
                }
                else
                {

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar buscar un cliente... " + ex);
            }

            return datosUser;
        }

        //Mostrar
        public void MostraDatosClientesSecretaria(DataGridView data)
        {

            String comando = "select cl.id_cliente as 'Codigo', cl.rut_cliente as 'Rut', cl.nombre_cliente+' '+" +
                                "cl.apellidos_cliente as 'Nombre', cl.fono_cliente as 'Fono', cl.cel_cliente as 'Celular'" +
                                    ", cl.direccion_cliente as 'Direccion', mas.nombre_mascota as 'Nombre Mascota', mas.id_mascota as 'Id Mascota'" +
                                        " from CLIENTE cl, MASCOTA mas, USUARIO us, CATEGORIA_MASCOTA cat where id_cliente_mascota=id_cliente and id_categoria_mascota=id_categoria " +
                                            "and id_usuario_mascota=id_usuario";
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

        /*********************************MASCOTA*********************************/
        //Crear
        public Boolean RegistrarMascotaSecretaria(Mascota masc)
        {
            SqlCommand insert;
            masc = new Mascota();
            Boolean exito = false;
            try
            {
                String comando = "insert into MASCOTA (nombre_mascota, edad_mascota, " +
                                    "peso_mascota, estatura_mascota, raza_mascota, observacion_mascota, id_cliente_mascota, "+
                                        "id_categoria_mascota, id_usuario_mascota) " +
                                            "values(@nombre, 0, 0, 0, '', '', @cliente, @categoria, 3)";

                insert = new SqlCommand(comando, con);

                insert.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar, 50).Value = masc.GetNombreMascota();
                insert.Parameters.Add("@cliente", System.Data.SqlDbType.Int).Value = masc.GetIdCliente();
                insert.Parameters.Add("@categoria", System.Data.SqlDbType.Int).Value = masc.GetIdCategoriaMascota();

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
                MessageBox.Show("Error al intentar registrar una nueva mascota... " + ex);
                exito = false;
            }
            return exito;
        }

        /*********************************MASCOTA-CLIENTE*********************************/

        //Verificar
        public Boolean VerificarClienteMascota(int codigo1, int codigo2)
        {
            SqlCommand select;
            Boolean existe = false;

            try
            {
                Conectar();
                String comando = "select count(*) from MASCOTA, CLIENTE where id_mascota=@codigomascota and id_cliente=@codigocliente and id_cliente_mascota=id_cliente";
                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@codigomascota", codigo1);
                select.Parameters.AddWithValue("@codigocliente", codigo2);

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

        //Obtener
        public ArrayList ObtenerNombreMascotaCliente(int codi1, int codi2)
        {
            SqlDataReader reader;
            ArrayList datosUser = new ArrayList();
            SqlCommand select;

            try
            {
                String comando = "select cli.nombre_cliente, cli.apellidos_cliente, masc.nombre_mascota "+
                                    " from CLIENTE cli, MASCOTA masc where id_mascota=@mascota and id_cliente=@cliente and id_cliente_mascota=id_cliente";
                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@mascota", codi1);
                select.Parameters.AddWithValue("@cliente", codi2);

                reader = select.ExecuteReader();

                if (reader.Read())
                {
                    datosUser.Add(reader["nombre_cliente"].ToString());
                    datosUser.Add(reader["apellidos_cliente"].ToString());
                    datosUser.Add(reader["nombre_mascota"].ToString());
                }
                else
                {

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar buscar un cliente... " + ex);
            }

            return datosUser;
        }

        /*********************************CITA*********************************/
        //Crear
        public Boolean RegistrarNuevaCita(String fecha, String descripcion, int cliente)
        {
            SqlCommand insert;
            Boolean exito = false;
            try
            {
                //Por defecto la cita estara con estado "En Espera" 
                String comando = "insert into CITA (fecha_cita, descripcion_cita, estado_cita, " +
                                    "id_cita_cliente) values(@fecha, @descrip, 0, @cliente)";

                insert = new SqlCommand(comando, con);

                insert.Parameters.Add("@fecha", System.Data.SqlDbType.DateTime).Value = fecha;
                insert.Parameters.Add("@descrip", System.Data.SqlDbType.VarChar, 40).Value = descripcion;
                insert.Parameters.Add("@cliente", System.Data.SqlDbType.Int).Value = cliente;

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

        //Mostrar
        public void MostrarCitasRealizadasSecretaria(DataGridView data)
        {

            String comando = "select ci.fecha_cita as 'Fecha Cita', ci.descripcion_cita as 'Descripcion', cl.rut_cliente as 'Run', " +
                                "cl.nombre_cliente +' '+cl.apellidos_cliente as 'Cliente' " +
                                    "from CITA ci, CLIENTE cl where id_cita_cliente=id_cliente and estado_cita=1";
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

        //Mostrar
        public void MostrarCitasEnEsperaSecretaria(DataGridView data)
        {

            String comando = "select ci.fecha_cita as 'Fecha Cita', ci.descripcion_cita as 'Descripcion', cl.rut_cliente as 'Run', " +
                                "cl.nombre_cliente +' '+cl.apellidos_cliente as 'Cliente', ci.id_cita as 'Codigo Cita'" +
                                    "from CITA ci, CLIENTE cl where id_cita_cliente=id_cliente and estado_cita=0";
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

        //Modificar
        public Boolean ModificarEstadoCitaSecretaria(int codi)
        {
            SqlCommand update;
            Boolean modificar = false;
            try
            {
                String comando = "update CITA set estado_cita=1 where id_cita=@codi and estado_cita=0";
                update = new SqlCommand(comando, con);

                update.Parameters.Add("@codi", System.Data.SqlDbType.Int).Value = codi;

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

        /*********************************CONSULTAS*********************************/
        //Crear
        public Boolean RegistrarNuevaConsulta(int mascota)
        {
            SqlCommand insert;
            Boolean exito = false;
            try
            {
                //Por defecto la cita estara con estado "En Espera" y la fecha será incluida de inmediato.
                //Restos de datos los ingresara el medico veterinario.
                String comando = "insert into CONSULTA (fecha_consulta, sintomas_consulta, diagnostico_consulta, " +
                                    "otra_consulta, estado_cosulta, id_consulta_mascota) values(GETDATE(), '', '', '',  0, @mascota)";

                insert = new SqlCommand(comando, con);

                insert.Parameters.Add("@mascota", System.Data.SqlDbType.Int).Value = mascota;

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

        //Mostrar
        public void MostrarConsultasRealizadasSecretaria(DataGridView data)
        {

            String comando = "select co.fecha_consulta as 'Fecha Consulta', co.sintomas_consulta as 'Sintomas', co.diagnostico_consulta as 'Diagnostico', " +
                                "co.otra_consulta as 'Otros', cl.rut_cliente as 'Run', cl.nombre_cliente +' '+ cl.apellidos_cliente as 'Nombre Cliente', " +
                                        " mas.nombre_mascota as 'Nombre Mascota' from CONSULTA co, CLIENTE cl, MASCOTA mas "+
                                                "where id_consulta_mascota=id_mascota and id_cliente_mascota=id_cliente and estado_cosulta=1";
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

        //Mostrar
        public void MostrarConsultasEnEsperaSecretaria(DataGridView data)
        {

            String comando = "select co.id_consulta as 'Codigo Consulta', co.fecha_consulta as 'Fecha Consulta', co.sintomas_consulta as 'Sintomas', co.diagnostico_consulta as 'Diagnostico', " +
                                "co.otra_consulta as 'Otros', cl.rut_cliente as 'Run', cl.nombre_cliente +' '+ cl.apellidos_cliente as 'Nombre Cliente', " +
                                        " mas.nombre_mascota as 'Nombre Mascota' from CONSULTA co, CLIENTE cl, MASCOTA mas " +
                                                "where id_consulta_mascota=id_mascota and id_cliente_mascota=id_cliente and estado_cosulta=0";
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

        //Modificar
        public Boolean ModificarEstadoConsultaSecretaria(int codi)
        {
            SqlCommand update;
            Boolean modificar = false;
            try
            {
                String comando = "update CONSULTA set estado_cosulta=1 where id_consulta=@codi";
                update = new SqlCommand(comando, con);

                update.Parameters.Add("@codi", System.Data.SqlDbType.Int).Value = codi;

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
    }
}
