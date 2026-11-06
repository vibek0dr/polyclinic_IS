using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class DvdMovie
{
    public string FilmName { get; set; } = null!;

    public string PerformerLastName { get; set; } = null!;

    public string DirectorLastName { get; set; } = null!;

    public int IdGenre { get; set; }

    public string Language { get; set; } = null!;

    public int DurationMin { get; set; }

    public DateOnly ReleaseDate { get; set; }

    public virtual ICollection<Deliviry> Deliviries { get; set; } = new List<Deliviry>();

    public virtual Director DirectorLastNameNavigation { get; set; } = null!;

    public virtual Genre IdGenreNavigation { get; set; } = null!;

    public virtual Performer PerformerLastNameNavigation { get; set; } = null!;

    public virtual ICollection<UserFavorite> UserFavorites { get; set; } = new List<UserFavorite>();
}
