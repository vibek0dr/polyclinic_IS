using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Uprajneniya
{
    public int IdUprajneniya { get; set; }

    public string NazvanieUprajneniya { get; set; } = null!;

    public virtual ICollection<Sorevnovaniya> Sorevnovaniyas { get; set; } = new List<Sorevnovaniya>();
}
