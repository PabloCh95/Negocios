using Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Functions
    {
        public static List<Client> ObtainClient()
        {
            SqlConnection Connection = Connecting.Connect();
            List<Client> Clients = new List<Client>();
            SqlCommand Command = new SqlCommand("selectClientes", Connection);
            Command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader DataReader = Command.ExecuteReader();

            while (DataReader.Read())
            {
                Client newClient = new Client();
                newClient.IdClient = DataReader.GetInt32(0);
                newClient.Nombre = DataReader.GetString(1);
                newClient.Apellido = DataReader.GetString(2);
                newClient.Fecha_Nacimiento = DataReader.GetString(3);
                newClient.Direccion = DataReader.GetString(4);

                Clients.Add(newClient);
            }
            Connection.Close();
            return Clients;
        }

        public static List<Product> ObtainProduct()
        {
            SqlConnection Connection = Connecting.Connect();
            List<Product> Products = new List<Product>();
            SqlCommand Command = new SqlCommand("selectProductos", Connection);
            Command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader DataReader = Command.ExecuteReader();

            while (DataReader.Read())
            {
                Product newProduct = new Product();
                newProduct.IdProduc = DataReader.GetInt32(0);
                newProduct.Nombre = DataReader.GetString(1);
                newProduct.Descripcion = DataReader.GetString(2);
                newProduct.Precio = DataReader.GetInt32(3);
                newProduct.Stock = DataReader.GetInt32(4);

                Products.Add(newProduct);
            }
            Connection.Close();
            return Products;
        }

        public static List<Combos> ObtainCombos()
        {
            SqlConnection Connection = Connecting.Connect();
            List<Combos> Combo = new List<Combos>();
            SqlCommand Command = new SqlCommand("selectCombos", Connection);
            Command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader DataReader = Command.ExecuteReader();

            while (DataReader.Read())
            {
                Combos newCombo = new Combos();
                newCombo.IdCliente = DataReader.GetInt32(0);
                newCombo.NombreCli = DataReader.GetString(1);
                newCombo.ApellidoCli = DataReader.GetString(2);
                newCombo.IdProducto = DataReader.GetInt32(3);
                newCombo.NombreP = DataReader.GetString(4);
                newCombo.PrecioP = DataReader.GetInt32(5);
                newCombo.CantidadP = DataReader.GetInt32(6);

                Combo.Add(newCombo);
            }
            Connection.Close();
            return Combo;
        }
    }
}
