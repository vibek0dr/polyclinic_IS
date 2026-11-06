using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class PokupatelTovar
{
    public int IdPokupatelTovar { get; set; }

    public int? IdTovar { get; set; }

    public int? IdPokupatel { get; set; }

    public int? Kolichestvo { get; set; }

    public virtual Pokupatel? IdPokupatelNavigation { get; set; }

    public virtual Tovar3? IdTovarNavigation { get; set; }
}
