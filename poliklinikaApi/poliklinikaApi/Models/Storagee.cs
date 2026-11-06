using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Storagee
{
    public int IdStorage { get; set; }

    public string Address { get; set; } = null!;

    public virtual ICollection<StorageBalance> StorageBalances { get; set; } = new List<StorageBalance>();

    public virtual ICollection<Waybill> Waybills { get; set; } = new List<Waybill>();
}
