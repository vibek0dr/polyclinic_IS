using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class CustomerCustomerDemo
{
    public string CustomerId { get; set; } = null!;

    public string CustomerType { get; set; } = null!;

    public virtual Customer? Customer { get; set; }

    public virtual CustomerDemographic CustomerTypeNavigation { get; set; } = null!;
}
