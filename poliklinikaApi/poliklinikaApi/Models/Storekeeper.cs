using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Storekeeper
{
    public int IdStorekeeper { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Patronymic { get; set; }

    public string? Telephone { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public int? Role { get; set; }

    public virtual ICollection<Waybill> Waybills { get; set; } = new List<Waybill>();
}
