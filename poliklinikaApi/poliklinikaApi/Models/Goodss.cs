using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Goodss
{
    public int IdGoods { get; set; }

    public string Name { get; set; } = null!;

    public string Measure { get; set; } = null!;

    public virtual ICollection<ApplicationGood> ApplicationGoods { get; set; } = new List<ApplicationGood>();

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual ICollection<StorageBalance> StorageBalances { get; set; } = new List<StorageBalance>();

    public virtual ICollection<StoreBalance> StoreBalances { get; set; } = new List<StoreBalance>();

    public virtual ICollection<WaybillGood> WaybillGoods { get; set; } = new List<WaybillGood>();
}
