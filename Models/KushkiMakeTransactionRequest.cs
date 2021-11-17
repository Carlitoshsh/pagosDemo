namespace DemoPagos.Models;

public class KushkiMakeTransactionRequest
{
    public string token { get; set; }
    public Amount amount { get; set; }
}