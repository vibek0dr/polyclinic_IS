using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Category
{
    public int IdCategory { get; set; }

    public string? CategoryName { get; set; }

    public string? Description { get; set; }

    public byte[]? Picture { get; set; }

    public virtual ICollection<Product1> Product1s { get; set; } = new List<Product1>();
}
