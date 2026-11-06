using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Kniga1
{
    public int IdKniga { get; set; }

    public string? Name { get; set; }

    public int? IdAvtor { get; set; }

    public int? IdIzdatelstvo { get; set; }

    public int? Amount { get; set; }

    public int? IdGenre { get; set; }

    public int? IdLanguage { get; set; }

    public virtual Avtori1? IdAvtorNavigation { get; set; }

    public virtual Genre1? IdGenreNavigation { get; set; }

    public virtual Izdatelstvo? IdIzdatelstvoNavigation { get; set; }

    public virtual Language? IdLanguageNavigation { get; set; }
}
