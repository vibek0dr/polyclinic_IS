using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class UserFavorite
{
    public int IdFavorite { get; set; }

    public int UserId { get; set; }

    public string FilmName { get; set; } = null!;

    public DateTime? AddedDate { get; set; }

    public virtual DvdMovie FilmNameNavigation { get; set; } = null!;

    public virtual UsersCd User { get; set; } = null!;
}
