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
    class ConsultasVeterinario : Conexion
    {
        //rescatar tabla
        DataTable dt;
        //obetner tabla
        SqlDataAdapter DA;

        /*********************************CONSULTAS*********************************/
        //Verificar
        public Boolean VerificarConsultaVeterinario(int codigo)
        {
            SqlCommand select;
            Boolean existe = false;

            try
            {
                Conectar();
                String comando = "select count(*) from CONSULTA where id_consulta=@codigo and estado_cosulta=0";
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
        public void MostrarConsultasEnEsperaVeterinario(DataGridView data)
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

        //Obtener
        public ArrayList ObtenerDatosConsultaVeterinario(int consulta)
        {
            SqlDataReader reader;
            ArrayList datosUser = new ArrayList();
            SqlCommand select;

            try
            {
                String comando = "select con.fecha_consulta, mas.id_mascota, mas.nombre_mascota from CONSULTA con, MASCOTA mas "+
                                    "where con.id_consulta=@consulta and con.id_consulta_mascota=mas.id_mascota";
                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@consulta", consulta);

                reader = select.ExecuteReader();

                if (reader.Read())
                {
                    datosUser.Add(reader["fecha_consulta"].ToString());
                    datosUser.Add(Convert.ToInt32(reader["id_mascota"]));
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

        //Modificar
        public Boolean ModificarConsultaVeterinario(int codi, String sinto, String diagno, String otro)
        {
            SqlCommand update;
            Boolean modificar = false;
            try
            {
                String comando = "update CONSULTA set sintomas_consulta=@sintoma, diagnostico_consulta=@diagnostico, "+
                                    "otra_consulta=@otros where id_consulta=@codi and estado_cosulta=0";
                update = new SqlCommand(comando, con);

                update.Parameters.Add("@sintoma", System.Data.SqlDbType.VarChar, 200).Value = sinto;
                update.Parameters.Add("@diagnostico", System.Data.SqlDbType.VarChar, 200).Value = diagno;
                update.Parameters.Add("@otros", System.Data.SqlDbType.VarChar, 200).Value = otro;
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

        /*********************************MASCOTA*********************************/
        //Verificar
        public Boolean VerificarMascotaVeterinario(String nombre, int codi)
        {
            SqlCommand select;
            Boolean existe = false;

            try
            {
                Conectar();
                String comando = "select count(*) from MASCOTA where id_mascota=@codi and nombre_mascota=@nombre";
                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@codi", codi);
                select.Parameters.AddWithValue("@nombre", nombre);

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
        public ArrayList ObtenerDatosMascotaVeterinario(int codi, String nom)
        {
            SqlDataReader reader;
            ArrayList datosUser = new ArrayList();
            SqlCommand select;

            try
            {
                String comando = "select mas.edad_mascota, mas.peso_mascota, mas.estatura_mascota, mas.raza_mascota, "+
			                        "mas.observacion_mascota, cat.id_categoria, cl.nombre_cliente from MASCOTA mas, CATEGORIA_MASCOTA cat, CLIENTE cl "+
				                        "where mas.id_mascota=@id and mas.nombre_mascota=@nom and mas.id_cliente_mascota=cl.id_cliente and mas.id_categoria_mascota=cat.id_categoria";

                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@id", codi);
                select.Parameters.AddWithValue("@nom", nom);

                reader = select.ExecuteReader();

                if (reader.Read())
                {
                    datosUser.Add(Convert.ToInt32(reader["edad_mascota"]));
                    datosUser.Add(Convert.ToDouble(reader["peso_mascota"]));
                    datosUser.Add(Convert.ToDouble(reader["estatura_mascota"]));
                    datosUser.Add(reader["raza_mascota"].ToString());
                    datosUser.Add(reader["observacion_mascota"]);
                    datosUser.Add(Convert.ToInt32(reader["id_categoria"]));
                    datosUser.Add(reader["nombre_cliente"].ToString());
                }
                else
                {

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener los datos de una mascota... " + ex);
            }

            return datosUser;
        }

        //Modificar
        public Boolean ModificarMascotaVeterinario(Mascota masc)
        {
            SqlCommand update;
            masc = new Mascota();
            Boolean modificar = false;
            try
            {
                String comando = "update MASCOTA set edad_mascota=@edad, peso_mascota=@peso, estatura_mascota=@estatura, " +
                                    "raza_mascota=@raza, observacion_mascota=@otros where id_mascota=@codimascota and nombre_mascota=@nombremascot";
                update = new SqlCommand(comando, con);
                
                update.Parameters.Add("@edad", System.Data.SqlDbType.Int).Value = masc.GetEdadMascota();
                update.Parameters.Add("@peso", System.Data.SqlDbType.Float).Value = masc.GetPesoMascota();
                update.Parameters.Add("@estatura", System.Data.SqlDbType.Float).Value = masc.GetEstaturaMascota();
                update.Parameters.Add("@raza", System.Data.SqlDbType.VarChar, 30).Value = masc.GetRazaMascota();
                update.Parameters.Add("@otros", System.Data.SqlDbType.VarChar, 200).Value = masc.GetObservacionesMascota();
                update.Parameters.Add("@codimascota", System.Data.SqlDbType.Int).Value = masc.GetIdMascota();
                update.Parameters.Add("@nombremascot", System.Data.SqlDbType.VarChar, 50).Value = masc.GetNombreMascota();

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

        /*********************************RECETA*********************************/
        //Crear
        public Boolean RegistrarRecetaVeterinario(string descrip, int id)
        {
            SqlCommand insert;
            Boolean exito = false;
            try
            {
                //Por defecto la clave será 12345 y estará disponible el usuario
                String comando = "insert into TRATAMIENTO (descripcion_tratamiento, id_tratamiento_mascota) " +
                                            "values(@descip, @codi)";

                insert = new SqlCommand(comando, con);

                insert.Parameters.Add("@descip", System.Data.SqlDbType.VarChar, 200).Value = descrip;
                insert.Parameters.Add("@codi", System.Data.SqlDbType.Int).Value = id;

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
                MessageBox.Show("Error al intentar registrar una nueva receta... " + ex);
                exito = false;
            }
            return exito;
        }

        /*********************************VACUNAS*********************************/
        //Crear
        public Boolean RegistrarVacunaVeterinario(String nombrevacuna, String fechaprog, String otrosva, int idmascota)
        {
            SqlCommand insert;
            Boolean exito = false;
            try
            {
                //Por defecto la fecha realizada estará en "" hasta que el veterinario la modifique.
                //Estado será "Programada" para posteriormente pasar a "Realizada"
                String comando = "insert into VACUNA (nombre_vacuna, fecha_programada, fecha_realizada, otros_vacuna, estado_vacuna, id_vacuna_mascota) " +
                                            "values(@nombre, @fechapro, '', @otros, 0, @idmascota)";

                insert = new SqlCommand(comando, con);

                insert.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar, 30).Value = nombrevacuna;
                insert.Parameters.Add("@fechapro", System.Data.SqlDbType.DateTime).Value = fechaprog;
                insert.Parameters.Add("@otros", System.Data.SqlDbType.VarChar, 100).Value = otrosva;
                insert.Parameters.Add("@idmascota", System.Data.SqlDbType.Int).Value = idmascota;

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
                MessageBox.Show("Error al intentar registrar una nueva vacuna para una mascota... " + ex);
                exito = false;
            }
            return exito;
        }

        //Metodo verificar la existencia de una vacuna
        public Boolean VerificarVacunaVeterinario(int codigo)
        {
            SqlCommand select;
            Boolean existe = false;

            try
            {
                Conectar();
                String comando = "select count(*) from VACUNA where id_vacuna=@codigo";
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
        public void MostrarRegistroVacunasProgramadasVeterinario(DataGridView data, int cod)
        {

            String comando = "select mas.nombre_mascota as 'Nombre Mascota', va.nombre_vacuna as 'Nombre Vacuna', "+
                                "va.fecha_programada as 'Fecha Programada', va.fecha_realizada as 'Fecha Realizada', "+
		                            "va.otros_vacuna as 'Extra', va.id_vacuna as 'ID Vacuna' from VACUNA va, MASCOTA mas "+
			                            "where mas.id_mascota='"+cod+"' and va.id_vacuna_mascota=mas.id_mascota and estado_vacuna=0";
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
        public void MostrarRegistroVacunasRealizadasVeterinario(DataGridView data, int cod)
        {

            String comando = "select mas.nombre_mascota as 'Nombre Mascota', va.nombre_vacuna as 'Nombre Vacuna', " +
                                "va.fecha_programada as 'Fecha Programada', va.fecha_realizada as 'Fecha Realizada', " +
                                    "va.otros_vacuna as 'Extra', va.id_vacuna as 'ID Vacuna' from VACUNA va, MASCOTA mas " +
                                        "where mas.id_mascota='" + cod + "' and va.id_vacuna_mascota=mas.id_mascota and estado_vacuna=1";
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
        public Boolean ModificarEstadoVacunaVeterinario(int codi)
        {
            SqlCommand update;
            Boolean modificar = false;
            try
            {
                String comando = "update VACUNA set fecha_realizada=GETDATE(), estado_vacuna=1 where id_vacuna=@codigo and estado_vacuna=0";
                update = new SqlCommand(comando, con);

                update.Parameters.Add("@codigo", System.Data.SqlDbType.Int).Value = codi;

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
                MessageBox.Show("Error al intentar modificar una vacuna... " + ex);
            }
            return modificar;
        }

    }
}
