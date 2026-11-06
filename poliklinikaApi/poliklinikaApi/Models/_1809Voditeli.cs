using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _1809Voditeli
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int? TruckId { get; set; }

    public string NomerPrav { get; set; } = null!;

    public int Dostupen { get; set; }

    public string? Kategorii { get; set; }

    public int? Staj { get; set; }

    public DateTime? DataPriyoma { get; set; }

    public string StatusDostupnosti { get; set; } = null!;

    public virtual _1809Gruzoviki1? Truck { get; set; }

    public virtual _1809User1 User { get; set; } = null!;

    public virtual ICollection<_1809Zakazy> _1809Zakazies { get; set; } = new List<_1809Zakazy>();
}
