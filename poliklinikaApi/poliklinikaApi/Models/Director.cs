using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Director
{
    public string DirectorLastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? Education { get; set; }

    public int? FilmsCount { get; set; }

    public virtual ICollection<DvdMovie> DvdMovies { get; set; } = new List<DvdMovie>();
}
