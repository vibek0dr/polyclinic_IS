using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Order1
{
    public int? OrderId { get; set; }

    public string? CustomerId { get; set; }

    public int? EmployerId { get; set; }

    public DateTime? Orderdate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public int? ShipVia { get; set; }

    public decimal? Freight { get; set; }

    public string? ShipName { get; set; }

    public string? ShipAdress { get; set; }

    public string? ShipCity { get; set; }

    public string? ShipRegion { get; set; }

    public string? ShipPostalCode { get; set; }

    public string? ShipCountry { get; set; }
}
