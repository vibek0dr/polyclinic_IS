using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Trainer
{
    public int TrainerId { get; set; }

    public int EmployeeId { get; set; }

    public string? Specialization { get; set; }

    public int? ExperienceYears { get; set; }

    public string? WorkSchedule { get; set; }

    public virtual Employees2 Employee { get; set; } = null!;

    public virtual ICollection<GroupClass> GroupClasses { get; set; } = new List<GroupClass>();

    public virtual ICollection<PersonalTraining> PersonalTrainings { get; set; } = new List<PersonalTraining>();
}
