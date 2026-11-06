using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0502DocumentByService
{
    public int Id { get; set; }

    public int ClientServiceId { get; set; }

    public string DocumentPath { get; set; } = null!;

    public virtual _0502ClientService ClientService { get; set; } = null!;
}
