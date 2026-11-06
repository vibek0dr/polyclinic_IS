using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Performer
{
    public string LastName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public string? Education { get; set; }

    public DateOnly BegininngOfCareer { get; set; }

    public virtual ICollection<DvdMovie> DvdMovies { get; set; } = new List<DvdMovie>();
}
