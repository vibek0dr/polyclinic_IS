using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Category1
{
    public int IdCategory { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Dish> Dishes { get; set; } = new List<Dish>();
}
