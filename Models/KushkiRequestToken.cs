namespace DemoPagos.Models;

public class Amount
{
    public double subtotalIva { get; set; } = 0;
    public double subtotalIva0 { get; set; }
    public double iva { get; set; } = 0;
}

public class KushkiRequestToken
{
    public string bankId { get; set; }
    public Amount amount { get; set; }
    public string callbackUrl { get; set; }
    public string userType { get; set; }
    public string documentType { get; set; }
    public string documentNumber { get; set; }
    public string paymentDescription { get; set; }
    public string email { get; set; }
    public string currency { get; set; }
}

public class KushkiResponse {
    public string token { get; set; }
}