using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Storage
{
    public int IdStorage { get; set; }

    public string Adress { get; set; } = null!;

    public virtual ICollection<JewelStorage> JewelStorages { get; set; } = new List<JewelStorage>();
}
