using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Waybill
{
    public int IdWaybill { get; set; }

    public int? IdUser { get; set; }

    public int IdStorage { get; set; }

    public int IdStore { get; set; }

    public virtual Storagee IdStorageNavigation { get; set; } = null!;

    public virtual Store IdStoreNavigation { get; set; } = null!;

    public virtual Userstore? IdUser1 { get; set; }

    public virtual Storekeeper? IdUserNavigation { get; set; }

    public virtual ICollection<WaybillGood> WaybillGoods { get; set; } = new List<WaybillGood>();
}
