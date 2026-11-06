using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class UsersCd
{
    public int IdUser { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<UserFavorite> UserFavorites { get; set; } = new List<UserFavorite>();
}
