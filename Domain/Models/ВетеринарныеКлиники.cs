using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class ВетеринарныеКлиники
{
    public int IdКлиники { get; set; }

    public string Название { get; set; } = null!;

    public string? Адрес { get; set; }

    public string? Телефон { get; set; }

    public string? Email { get; set; }

    public decimal? Рейтинг { get; set; }

    public virtual ICollection<ВакцинацииПитомцев> ВакцинацииПитомцевs { get; set; } = new List<ВакцинацииПитомцев>();

    public virtual ICollection<ВетеринарныеВизиты> ВетеринарныеВизитыs { get; set; } = new List<ВетеринарныеВизиты>();
}
