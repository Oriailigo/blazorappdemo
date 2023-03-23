using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

public class MyService
{
    private readonly IConfiguration _config;

    public MyService(IConfiguration config)
    {
        _config = config;
    }

    public MySqlConnection GetConnection()
    {
        string connectionString = _config.GetConnectionString("DefaultConnection");
        MySqlConnection connection = new MySqlConnection(connectionString);
        return connection;
    }
}
