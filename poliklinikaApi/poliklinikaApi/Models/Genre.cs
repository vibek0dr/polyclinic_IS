using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Genre
{
    public int IdGenre { get; set; }

    public string NameOfGenre { get; set; } = null!;

    public int YearOfAppearance { get; set; }

    public string PlaceOfApperance { get; set; } = null!;

    public virtual ICollection<DvdMovie> DvdMovies { get; set; } = new List<DvdMovie>();
}
