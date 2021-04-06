using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pruebaaa
{

    //CLASE PARA LA CONEXION DE LA BASE DE DATOS
    class Datos
    {

        SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-GAB0UPU;Initial Catalog=Afijos;Integrated Security=True");

        SqlCommand comandos;







        //LOGUEO DE USUARIOS NUEVOS //

        public void Register(string nombre, string user, string clave)
        {
            Conexion.Open();

            string datocomand = $"INSERT INTO LOGI VALUES ('{nombre}', '{user}','{clave}')";
            comandos = new SqlCommand(datocomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();

        }


        ////////// REGISTRO DE LOS USUARIOS //////
        ///

       

        public void USUARIOS(string nombre, string apellido, string cedula, string genero, string  fechan, string direccion, string email, string celular, string telefono, string acad, string estd, string trabajo)
        {

            Conexion.Open();
            string datocomand = $"INSERT INTO USUARIO VALUES('{nombre}','{apellido}','{cedula}','{genero}','{fechan}','{direccion}','{email}','{celular}','{telefono}','{acad}','{estd}','{trabajo}')";
            comandos = new SqlCommand(datocomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();


        }



        public void EMPLEADOS( string nom, string apell,string cedula, string fecha2, string fecha1, string sueldo, string cel, string tel, string email, string direc, string ocup,string estdo)
        {

            Conexion.Open();
            string datcomand= $"INSERT INTO PERSONAL VALUES ('{nom}','{apell}','{cedula}','{fecha1}','{fecha2}','{cel}','{tel}','{email}','{direc}','{ocup}','{estdo}','{sueldo}')";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();
        }








        ////// METODO REGISTROS DE CARROS

        public void CARROS(string codigo, string marca, string modelo, string año, string cantidad, string precioI, string precioA, string fechaI, string propt)
        {
            Conexion.Open();
            string datcomand = $"INSERT INTO CARROS VALUES ('{codigo}','{marca}','{modelo}','{año}','{cantidad}','{precioI}','{precioA}','{fechaI}','{propt}')";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();
        }


        //REGISTRO DE LOS  CASA //
        public void PROPIEDADES( string catas, string met, string ubiccacion , string cantidad, string valori, string valrf, string fecha , string deu, string propie, string titulo)
        {

            Conexion.Open();
            string datcomand = $"INSERT INTO CASAS VALUES('{catas}','{met}','{ubiccacion}','{cantidad}','{valori}','{valrf}','{fecha}','{deu}','{propie}','{titulo}')";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();
        }




     //REGISTRO DE LAS EDIFICACIONES //

        public void  EDIFICACION (string catast, string metr, string ubic, string cantid, string val1, string val2, string fech, string deud, string due, string titl)
        {
            Conexion.Open();
            string datcomand = $"INSERT INTO EDIFICACION VALUES('{catast}','{metr}','{ubic}','{cantid}','{val1}','{val2}','{fech}','{deud}','{due}','{titl}')";
             comandos= new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();



        }


        //REGISTRO DE MAQUINARIAS

        public void MAQUINARIAS(string coig, string model, string marc, string year, string cand, string vl1, string vl2, string pro, string Fi)
        {
            Conexion.Open();
            string datcomand = $"INSERT INTO MAQUINARIAS VALUES('{coig}','{model}','{marc}','{year}','{cand}','{vl1}','{vl2}','{pro}','{Fi}')";
            comandos = new SqlCommand(datcomand, Conexion);
            comandos.ExecuteNonQuery();
            Conexion.Close();



        }





        /////////////////////////////////METODOS PARA ACTUALIZAR LOS DATOS////////////////////////////////////////











        /////////////////////////////////METODOS PARA ELIMINAR LOS DATOS////////////////////////////////////////



















        ///////////////////////////// METODO PARA BUSCAR DATOS///////////////////////////////////////////////////
        ///


        public void BUSCEMPLEADOS( string cedula )

        {
            Conexion.Open();
           
        


            Conexion.Close();

        }







        ///////////METODO PARA LLENAR LA TABLA CON LOS DATOS



        public DataTable DATOSEMPLEADOS()

        {
            Conexion.Open();

            string datcomand = $"SELECT* FROM PERSONAL";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);

            Conexion.Close();
            return table;
        }




        public DataTable DATOSUSUARIOS()

        {
            Conexion.Open();

            string datcomand = $"SELECT* FROM USUARIO";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);

            Conexion.Close();
            return table;
        }



        public DataTable DATOSCARROS()

        {
            Conexion.Open();

            string datcomand = $"SELECT* FROM CARROS";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);

            Conexion.Close();
            return table;
        } 



        public DataTable DATOSCASAS()

        {
            Conexion.Open();

            string datcomand = $"SELECT* FROM CASAS";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);

            Conexion.Close();
            return table;
        }


        public DataTable DATOSEDIFCIO()

        {
            Conexion.Open();

            string datcomand = $"SELECT* FROM EDIFICACION";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);

            Conexion.Close();
            return table;
        }

        public DataTable DATOSMAQUINARIAS()

        {
            Conexion.Open();

            string datcomand = $"SELECT* FROM MAQUINARIAS";
            comandos = new SqlCommand(datcomand, Conexion);
            SqlDataAdapter data = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            data.Fill(table);

            Conexion.Close();

            return table;
        }



       //////// // METODOS PARA BUSQUEDAD DE LOS DATOS /////////
       
        public void BEMPLEADOS(string cedula)
        {

        }










    }

}









