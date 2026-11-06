using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class ClientImport
{
    public string? Имя { get; set; }

    public string? Фамилия { get; set; }

    public string? Отчество { get; set; }

    public string? ДатаРождения { get; set; }

    public string? ДатаРегистрации { get; set; }

    public string? Email { get; set; }

    public string? Телефон { get; set; }

    public string? Пол { get; set; }

    public string? ФотографияКлиента { get; set; }
}
