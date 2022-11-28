class Payment
{

public int Id { get; set; }
public int OrderId { get; set; }
public int Amount { get; set; }
public int Provider { get; set; }   // 1 = PayPal, 2 = Stripe, 3 = Klarna
public int Status { get; set; }     // 1 = Pending, 2 = Paid, 3 = Failed
public string CreatedAt { get; set; } // DateTime

}