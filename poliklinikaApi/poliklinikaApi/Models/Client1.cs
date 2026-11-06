using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Client1
{
    public int IdClient { get; set; }

    public string? Fio { get; set; }

    public string? Adres { get; set; }

    public string? Telephone { get; set; }

    public DateOnly? DataRojdeniya { get; set; }

    public virtual ICollection<Zakaz2> Zakaz2s { get; set; } = new List<Zakaz2>();
}
