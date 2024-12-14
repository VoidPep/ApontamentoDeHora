using System.Configuration;
using System.Data.SQLite;

namespace ApontamentoDeHoras.Domain.Helpers;

public class DatabaseHelper
{
    public static void CreateDatabase()
    {
        var connectionString = GetConnectionString();
        using var connection = new SQLiteConnection(connectionString);
        connection.Open();

        string createTableQuery =
            @"CREATE TABLE IF NOT EXISTS HorasApontadas (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Ticket INTEGER NOT NULL,
                Atividade TEXT NOT NULL,
                HoraInicial DATETIME NOT NULL,
                HoraFinal DATETIME NOT NULL
            );";

        using var command = new SQLiteCommand(createTableQuery, connection);
        command.ExecuteNonQuery();
    }

    public static string GetConnectionString() => ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString;
}
