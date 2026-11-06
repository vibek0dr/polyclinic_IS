using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class OtdelKadrov
{
    public int IdOtdelaKadrov { get; set; }

    public string? Adres { get; set; }

    public int? Archiv { get; set; }

    public virtual Archiv? ArchivNavigation { get; set; }
}
