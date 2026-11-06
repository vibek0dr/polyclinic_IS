using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public int SaleId { get; set; }

    public int AmountRub { get; set; }

    public string Type { get; set; } = null!;

    public DateTime TransactionDate { get; set; }
}
