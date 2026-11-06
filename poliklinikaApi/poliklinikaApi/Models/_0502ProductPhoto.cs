using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0502ProductPhoto
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string PhotoPath { get; set; } = null!;

    public virtual _0502Product Product { get; set; } = null!;
}
