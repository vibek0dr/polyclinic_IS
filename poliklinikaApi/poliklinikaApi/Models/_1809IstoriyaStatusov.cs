using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _1809IstoriyaStatusov
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public string? StaryyStatus { get; set; }

    public string NovyyStatus { get; set; } = null!;

    public int IzmenilUserId { get; set; }

    public DateTime Izmeneno { get; set; }

    public string? Kommentariy { get; set; }

    public virtual _1809User1 IzmenilUser { get; set; } = null!;

    public virtual _1809Zakazy Order { get; set; } = null!;
}
