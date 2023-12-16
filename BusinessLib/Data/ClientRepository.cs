using BusinessLib.Common;
using Microsoft.Data.SqlClient;

namespace BusinessLib.Data;

// the client repository
public class ClientRepository
{
    // table name
    private const string tableName = "Client238867";

    // get the client by the code
    public static Client GetClientByCode(int clientCode) => GetClients(clientCode)[0];

    // getClients
    public static ClientList GetClients(int clientCode = -1)
    {
        string sql = $"""
                      SELECT ClientCode,
                            CompanyName,
                            Address1,
                            Address2,
                            City,
                            Province,
                            PostalCode,
                            YTDSales,
                            CreditHold,
                            Notes
                      FROM {tableName} 
                      """;

        if (clientCode > -1)
        {
            sql += " WHERE ClientCode = @clientCode";
        }

        using SqlConnection conn = new(Config.ConnectionString);
        using SqlCommand cmd = new(sql, conn);

        if (clientCode > -1)
        {
            cmd.Parameters.AddWithValue("@clientCode", clientCode);
        }

        conn.Open();

        using SqlDataReader reader = cmd.ExecuteReader();

        ClientList clients = new();
        
        // while the reader has something to read
        while (reader.Read())
        {
            clients.Add(new Client
            {
                ClientCode = reader["ClientCode"] as string,
                CompanyName = reader["CompanyName"] as string,
                Address1 = reader["Address1"] as string,
                Address2 = reader["Address2"] as string,
                City = reader["City"] as string,
                Province = reader["Province"] as string,
                PostalCode = reader["postalCode"] as string,
                YtdSales = (decimal)reader["YTDSales"],
                CreditHold = (bool)reader["CreditHold"],
                Notes = reader["Notes"] as string
            });
            
        }
           
         return clients;
      
    }

    //Add Client to table
    public static int AddClient(Client client)
    {
        string sql = $"""
                        INSERT INTO {tableName}
                        (
                            ClientCode,
                            CompanyName,
                            Address1,
                            Address2,
                            City,
                            Province,
                            PostalCode,
                            YTDSales,
                            CreditHold,
                            Notes
                        )
                        VALUES
                        (
                            @clientCode,
                            @companyName,
                            @address1,
                            @address2,
                            @city,
                            @province,
                            @postalCode,
                            @ytdSales,
                            @creditHold,
                            @notes
                        )
                      """;

        return processQuery(sql, client);
    }



    // Update an existing client
    public static int UpdateClient(Client client)
    {
        string sql = $"""
                      UPDATE {tableName}
                      SET
                        CompanyName = @companyName,
                        Address1 = @address1,
                        Address2 = @address2,
                        City = @city,
                        Province = @province,
                        PostalCode = @postalCode,
                        YTDSales = @ytdSales,
                        CreditHold = @creditHold,
                        Notes = @notes
                      WHERE ClientCode = @clientCode
                      """;

        return processQuery(sql, client);
    }

    // Delete an existing client
    public static int DeleteClient(Client client)
    {
        string sql = $"""
                      DELETE {tableName}
                      WHERE ClientCode = @clientCode
                      """;

        using SqlConnection conn = new(Config.ConnectionString);
        using SqlCommand cmd = new(sql, conn);

        cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

        conn.Open();
        return cmd.ExecuteNonQuery();
    }


    // process the query
    private static int processQuery(string sql, Client client)
    {
        using SqlConnection conn = new(Config.ConnectionString);
        using SqlCommand cmd = new(sql, conn);

        cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);
        cmd.Parameters.AddWithValue("@companyName", client.CompanyName);
        cmd.Parameters.AddWithValue("@address1", client.Address1);
        cmd.Parameters.AddWithValue("@address2", (object)client.Address2 ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@city", (object)client.City ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@province", client.Province);
        cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
        cmd.Parameters.AddWithValue("@ytdSales", client.YtdSales);
        cmd.Parameters.AddWithValue("@creditHold", client.CreditHold);
        cmd.Parameters.AddWithValue("@notes", (object)client.Notes ?? DBNull.Value);

        conn.Open();
        int rowsAffected = cmd.ExecuteNonQuery();
        return rowsAffected;
    }

}