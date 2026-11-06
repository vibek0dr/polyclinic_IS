using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class GroupClass
{
    public int ClassId { get; set; }

    public int TrainerId { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly ClassDate { get; set; }

    public TimeOnly StartTime { get; set; }

    public int DurationMin { get; set; }

    public int MaxParticipants { get; set; }

    public virtual ICollection<ClassBooking> ClassBookings { get; set; } = new List<ClassBooking>();

    public virtual Trainer Trainer { get; set; } = null!;
}
