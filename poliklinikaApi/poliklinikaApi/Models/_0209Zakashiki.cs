using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0209Zakashiki
{
    public int? IdZakashika { get; set; }

    public string? Fio { get; set; }

    public int? Inn { get; set; }

    public string? Adres { get; set; }

    public string? Telephone { get; set; }

    public bool? Pokupatel { get; set; }

    public bool? Prodavec { get; set; }

    public virtual _0209Zakaz? IdZakashikaNavigation { get; set; }
}
