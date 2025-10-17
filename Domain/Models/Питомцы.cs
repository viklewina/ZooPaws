using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Питомцы
{
    public int IdПитомца { get; set; }

    public int IdПользователя { get; set; }

    public int IdПороды { get; set; }

    public string Кличка { get; set; } = null!;

    public DateOnly? ДатаРождения { get; set; }

    public string? Пол { get; set; }

    public decimal? Вес { get; set; }

    public DateTime? ДатаДобавления { get; set; }

    public virtual Пользователи IdПользователяNavigation { get; set; } = null!;

    public virtual Породы IdПородыNavigation { get; set; } = null!;

    public virtual ICollection<ВакцинацииПитомцев> ВакцинацииПитомцевs { get; set; } = new List<ВакцинацииПитомцев>();

    public virtual ICollection<ВетеринарныеВизиты> ВетеринарныеВизитыs { get; set; } = new List<ВетеринарныеВизиты>();

    public virtual ICollection<РационПитомцев> РационПитомцевs { get; set; } = new List<РационПитомцев>();
}
