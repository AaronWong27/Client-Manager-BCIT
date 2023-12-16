namespace BusinessLib.Common;

public class Client
{
    // the code of the client
    public string ClientCode { get; set; }
    // the name of the client
    public string CompanyName { get; set; }
    // the address1 of the client
    public string Address1 { get; set; }
    // the address2 of the client
    public string? Address2 { get; set; }
    // the city of the client
    public string? City { get; set; }
    // the province of the client
    public string Province { get; set; }
    // the postal code of the client
    public string? PostalCode { get; set; }
    // the ytdsales of the client
    public decimal YtdSales { get; set; }
    // the credit hold of the client
    public bool CreditHold { get; set; }
    // the notes of the client
    public string? Notes { get; set; }



}
