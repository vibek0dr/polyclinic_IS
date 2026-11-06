using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class TovarSklad
{
    public int IdTovarSklad { get; set; }

    public int? IdTovar { get; set; }

    public int? IdSklad { get; set; }

    public int? Status { get; set; }

    public virtual Sklad? IdSkladNavigation { get; set; }

    public virtual Tovar3? IdTovarNavigation { get; set; }

    public virtual StatusTovara? StatusNavigation { get; set; }
}
