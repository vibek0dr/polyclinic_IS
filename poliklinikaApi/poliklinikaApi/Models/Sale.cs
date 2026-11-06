using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Sale
{
    public int SaleId { get; set; }

    public int ClientId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime SaleDate { get; set; }

    public int TotalAmountRub { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public virtual Client2 Client { get; set; } = null!;

    public virtual Employees2 Employee { get; set; } = null!;

    public virtual ICollection<SaleProduct> SaleProducts { get; set; } = new List<SaleProduct>();

    public virtual ICollection<SaleService> SaleServices { get; set; } = new List<SaleService>();
}
