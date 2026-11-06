using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Deliviry
{
    public int IdDelivery { get; set; }

    public string FilmName { get; set; } = null!;

    public DateOnly DeliviryDate { get; set; }

    public int Price { get; set; }

    public string CompanyName { get; set; } = null!;

    public virtual Supplierss CompanyNameNavigation { get; set; } = null!;

    public virtual DvdMovie FilmNameNavigation { get; set; } = null!;
}
