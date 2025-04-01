using Microsoft.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class conn
    {
        public conn() { }

        secrets s = new();

        public void addClient(string nombre, string apellido, string correo, string telefono) { 
            using (SqlConnection conn = new(s.Connection))
            {
                conn.Open();
                using (SqlCommand cmd = new($"InsertClients", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        public void addVenta(int idCliente, DateTime fechaVenta, int productosVendidos, int cantidadProductos, decimal precioTotal, string metodoPago, string estadoVenta, string documentoRespaldo, DateTime fechaEntrega, DateTime fechaRetiro) {
            using (SqlConnection conn = new(s.Connection))
            {
                conn.Open();
                using (SqlCommand cmd = new("InsertVentas", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    cmd.Parameters.AddWithValue("@fechaVenta", fechaVenta);
                    cmd.Parameters.AddWithValue("@productosVendidos", productosVendidos);
                    cmd.Parameters.AddWithValue("@cantidadProductos", cantidadProductos);
                    cmd.Parameters.AddWithValue("@precioTotal", precioTotal);
                    cmd.Parameters.AddWithValue("@metodoPago", metodoPago);
                    cmd.Parameters.AddWithValue("@estadoPago", estadoVenta);
                    cmd.Parameters.AddWithValue("@documentoRespaldo", documentoRespaldo);
                    cmd.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);
                    cmd.Parameters.AddWithValue("@fechaRetiro", fechaRetiro);


                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        public List<string> getClientsName()
        {
            using (SqlConnection conn = new SqlConnection(s.Connection))
            {
                conn.Open();
                using (SqlCommand cmd = new("SELECT nombre FROM clientes", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<string> clients = new();
                        while (reader.Read())
                        {
                            clients.Add(reader.GetString(0));
                        }
                        return clients;
                    }
                }
            }
        }

        public List<string> getClientsSname()
        {
            using (SqlConnection conn = new SqlConnection(s.Connection))
            {
                conn.Open();
                using (SqlCommand cmd = new("SELECT apellido FROM clientes", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<string> clients = new();
                        while (reader.Read())
                        {
                            clients.Add(reader.GetString(0));
                        }
                        return clients;
                    }
                }
            }
        }

        public int getId(string client, string apellido)
        {
            using (SqlConnection conn = new SqlConnection(s.Connection))
            {
                conn.Open();
                using (SqlCommand cmd = new("SELECT id_cliente FROM clientes WHERE nombre=@nombre AND apellido=@apellido;", conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", client);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int id = 0;
                        if (reader.Read())
                        {
                            id = reader.GetInt32(0);
                        }
                        return id;
                    }
                }
            }
        }
    }
}
