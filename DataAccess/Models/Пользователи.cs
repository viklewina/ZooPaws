using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Пользователи
{
    public int IdПользователя { get; set; }

    public string Имя { get; set; } = null!;

    public string? Фамилия { get; set; }

    public string Email { get; set; } = null!;

    public string Пароль { get; set; } = null!;

    public virtual ICollection<Питомцы> Питомцыs { get; set; } = new List<Питомцы>();
}
