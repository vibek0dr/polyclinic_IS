using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class CustomerDemographic
{
    public string CustomerTypeId { get; set; } = null!;

    public string? CustomerDesc { get; set; }

    public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; } = new List<CustomerCustomerDemo>();
}
