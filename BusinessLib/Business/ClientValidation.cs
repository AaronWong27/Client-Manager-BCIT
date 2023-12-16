using BusinessLib.Common;
using BusinessLib.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessLib.Business;

// clientValidation class
public class ClientValidation
{
    private static List<string> errors = new();

    // error message
    public static string ErrorMessage
    {
        get
        {
            StringBuilder sb = new();

            foreach (string error in errors)
            {
                sb.AppendLine(error);
            }

            return sb.ToString();
        }
    }

    // get the list of clients
    public static ClientList GetClients()
    {
        return ClientRepository.GetClients();
    }

    // validate, then add a client
    public static int AddClient(Client client)
    {
        if (validate(client))
        {
            return ClientRepository.AddClient(client);
        }
        else
        {
            return -1;
        }
    }

    // validate, then update a client
    public static int UpdateClient(Client client)
    {
        if (validate(client))
        {
            return ClientRepository.UpdateClient(client);
        }
        else
        {
            return -1;
        }
    }

    // delete client
    public static int DeleteClient(Client client) => ClientRepository.DeleteClient(client);

    // validate client
    private static bool validate(Client client)
    {
        string regExProvince = @"^[A-Za-z]{2}$";
        string regExPostalCode = @"^[A-Za-z]\d[A-Za-z] \d[A-Za-z]\d$";
        bool success = true;
        errors.Clear();

        if (string.IsNullOrWhiteSpace(client.ClientCode))
        {
            errors.Add("ClientCode cannot be empty");
            success = false;
        }

        if (string.IsNullOrWhiteSpace(client.CompanyName))
        {
            errors.Add("CompanyName cannot be empty");
            success = false;
        }

        if (string.IsNullOrWhiteSpace(client.Address1))
        {
            errors.Add("Address1 cannot be empty");
            success = false;
        }

        if (string.IsNullOrWhiteSpace(client.Province) || !Regex.IsMatch(client.Province, regExProvince))
        {
            errors.Add("Province cannot be empty and must be in the format AA");
            success = false;
        }

        if (string.IsNullOrWhiteSpace(client.PostalCode) || !Regex.IsMatch(client.PostalCode, regExPostalCode))
        {
            errors.Add("PostalCode cannot be empty and must be in the format A9A 9A9");
            success = false;
        }

        return success;
    }
}
