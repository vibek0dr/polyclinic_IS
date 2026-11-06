using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Employees2
{
    public int EmployeeId { get; set; }

    public int UserId { get; set; }

    public DateOnly HireDate { get; set; }

    public string Position { get; set; } = null!;

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();

    public virtual ICollection<Trainer> Trainers { get; set; } = new List<Trainer>();

    public virtual User2 User { get; set; } = null!;
}
