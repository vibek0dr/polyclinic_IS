using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Kniga
{
    public int IdKnigi { get; set; }

    public string? Nazvanie { get; set; }

    public int? Avtor { get; set; }

    public string? Izdatelstvo { get; set; }

    public string? GodIzdaniya { get; set; }

    public string? KolvoStranic { get; set; }

    public int? KolichestvoEzkemplyarovVBiblioteke { get; set; }

    public int? OblastZnaniy { get; set; }

    public virtual OblastZnaniy? OblastZnaniyNavigation { get; set; }
}
