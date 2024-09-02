using MySql.Data.MySqlClient;
using System.Data;

namespace Conexiones
{
    public class Conexion
    {
        public DataTable tablaClientes = new DataTable();

        public DataTable tablaSucursales = new DataTable();

        public void crearTablaClientes()
        {
            tablaClientes.Columns.Add("Codigo", typeof(string));
            tablaClientes.Columns.Add("Nombre", typeof(string));
            tablaClientes.Columns.Add("Teléfono", typeof(string));
            tablaClientes.Columns.Add("Correo", typeof(string));
            tablaClientes.Columns.Add("Sucursal", typeof(string));
        }

        public void crearTablaSucursales()
        {
            tablaSucursales.Columns.Add("Codigo", typeof(int));
            tablaSucursales.Columns.Add("Nombre", typeof(string));
        }



        MySqlConnection conn = new MySqlConnection("server=localhost;" +
                                                   "database=bd1;" +
                                                   "user=root;" +
                                                   "password=;");

        public DataTable ObtenerDatosClientes()
        {
            tablaClientes.Clear();
            conn.Open();

            string sql = "SELECT * FROM clientes";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tablaClientes.Rows.Add(reader.GetInt32("numero"),
                                       reader.GetString("nombre"),
                                       reader.GetString("telefono"),
                                       reader.GetString("correo"),
                                       reader.GetInt32("sucursal"));
            }

            conn.Close();

            return tablaClientes;
        }

        public DataTable ObtenerDatosSucursales()
        {
            tablaSucursales.Clear();
            conn.Open();

            string sql = "SELECT * FROM sucursales";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tablaSucursales.Rows.Add(reader.GetInt32("codigo"),
                                         reader.GetString("nombre"));
            }

            conn.Close();

            return tablaSucursales;
        }

        public void GuardarCliente(string nombre, 
                                   string telefono, 
                                   string correo, 
                                   string sucursal)
        {
            conn.Open();

            string sql = "INSERT INTO clientes(nombre, telefono, correo, sucursal) " +
                         "VALUES (@nombre, @telefono, @correo, @sucursal)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@sucursal", sucursal);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void EliminarCliente(string numero, 
                                    string nombre, 
                                    string telefono, 
                                    string correo, 
                                    string sucursal)
        {
            conn.Open();

            string sql = "DELETE FROM clientes WHERE " +
                         "numero=@numero AND " +
                         "nombre=@nombre AND " +
                         "telefono=@telefono AND " +
                         "correo=@correo AND " +
                         "sucursal=@sucursal";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@sucursal", sucursal);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void ModificarCliente(string numero, 
                                     string nombre, 
                                     string telefono, 
                                     string correo, 
                                     string sucursal)
        {
            conn.Open();

            string sql = "UPDATE clientes SET " +
                         "nombre=@nombre," +
                         "telefono=@telefono," +
                         "correo=@correo," +
                         "sucursal=@sucursal WHERE " +
                         "numero=@numero";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@sucursal", sucursal);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

    }
}