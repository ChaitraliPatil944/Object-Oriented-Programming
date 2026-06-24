namespace TFLBank.model;

public class Operation{

    public string accountNumber { get; set; }
    public string Status { get; set; }
    public string StatusMessage { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal Amount { get; set; }
    public decimal CurrentBalance { get; set; }
}