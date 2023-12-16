using BusinessLib.Common;
using BusinessLib.Business;
//using BusinessLib.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace COMP3602Assign06;

// class client viewmodel that inherits ViewModelBase
public class ClientViewModel : ViewModelBase
{
    //constructor of ClientViewModel
    public ClientViewModel()
    {
        this.Clients = ClientValidation.GetClients();
        this.Client = new Client();

    }

    // refresh the client list from the database
    public void RefreshClientListFromDb() => Clients = ClientValidation.GetClients();

    // Clientlist of clients
    public ClientList Clients { get; private set; }

    // declaration client
    private Client client;

    // constructor of a client in ClientViewModel
    public Client Client
    {
        get { return client; }

        set
        {
            client = value;
            OnPropertyChanged();
        }
    }

    // setup the client
    public void SetDisplayClient(Client client)
    {
        this.Client = new Client
        {
            ClientCode = client.ClientCode,
            CompanyName = client.CompanyName,
            Address1 = client.Address1,
            Address2 = client.Address2,
            City = client.City,
            Province = client.Province,
            PostalCode = client.PostalCode,
            YtdSales = client.YtdSales,
            CreditHold = client.CreditHold,
            Notes = client.Notes,
        };
    }

    // display the client
    public Client GetDisplayClient()
    {
        return this.Client;
    }
}

