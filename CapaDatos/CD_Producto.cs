
using Capa_Entidad;
using Capa_Interfaces;

using CapaDatos;
using Npgsql;


namespace Capa_Datos
{
    public class CD_Producto : IProducto
    {
        public Task<IEnumerable<Producto>> ObtenerProductos()
{
    var lista = new List<Producto>();
    string CadenaConexion = ClassConexion.CadenaConexion; // Asegúrate de tener la cadena correcta.

    // Cambiamos SQLiteConnection a NpgsqlConnection para PostgreSQL
    using (var connection = new NpgsqlConnection(CadenaConexion))
    {
        connection.Open();
        var command = new NpgsqlCommand("SELECT * FROM producto", connection);
        
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                var producto = new Producto
                {
                    IdProducto = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Descripcion = reader.GetString(2),
                    IdMarca = reader.GetInt32(3),
                    IdCategoria = reader.GetInt32(4),
                    Precio = reader.GetDecimal(5),
                    Stock = reader.GetInt32(6),
                    Ruta_Imagen = reader.GetString(7),
                    Nombre_Imagen = reader.GetString(8),
                    Activo = reader.GetBoolean(9),
                    Fecha_Registro = reader.GetString(10),
                };
                lista.Add(producto);
            }
        }
    }
    
    return Task.FromResult<IEnumerable<Producto>>(lista);
}
       
    }
}
