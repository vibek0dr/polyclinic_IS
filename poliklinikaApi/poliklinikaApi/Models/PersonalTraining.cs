using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class PersonalTraining
{
    public int TrainingId { get; set; }

    public int ClientId { get; set; }

    public int TrainerId { get; set; }

    public DateTime RequestDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual Trainer Trainer { get; set; } = null!;
}
