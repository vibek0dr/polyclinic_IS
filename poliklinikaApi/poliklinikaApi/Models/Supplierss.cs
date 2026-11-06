using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Supplierss
{
    public string CompanyName { get; set; } = null!;

    public string SupplierCountry { get; set; } = null!;

    public string SupplierCity { get; set; } = null!;

    public virtual ICollection<Deliviry> Deliviries { get; set; } = new List<Deliviry>();
}
