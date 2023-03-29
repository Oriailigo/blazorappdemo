using System.Net.Http.Json;
using System.Text.Json;
using blazorappdemo;
using MySqlConnector;
public class DataContext: IDataContext
{

    public async Task<List<Usuario>?> Get()
    {
        var ConnectionStrings= "Server=localhost;UserID=root;Password='';Database=test";
        //open a connection asynchronously
        using var connection = new MySqlConnection(ConnectionStrings);
        await connection.OpenAsync();
    
        //create a DB command and set the SQL statement with parameters
        using var command = new MySqlCommand("SELECT * FROM usuario;", connection);
        await using var reader = await command.ExecuteReaderAsync();
        var usuarios = new List<Usuario>();
        while (await reader.ReadAsync()){
            
            var usuario = new Usuario()
             {
                 Id = reader.GetInt32("id"),
                 Nombre = reader.GetString("nombre"),
                 Contraseña = reader.GetString("contraseña"),
                 
             };
             usuarios.Add(usuario);
        }
        reader.Close();
        return usuarios;
    }    
    
}
 public interface IDataContext
   {
        Task<List<Usuario>?> Get();
     
    }
