class Payment
{
    public int Id { get; set; }

    public int CustumerId { get; set; }
    public int OrderId { get; set; }
    public int Amount { get; set; }
    public string Provider { get; set; }
    public string Status { get; set; }
    public int CreatedAt { get; set; }

public Payment(){}
}

