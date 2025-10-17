using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class ВетеринарныеВизиты
{
    public int IdВизита { get; set; }

    public int IdПитомца { get; set; }

    public int IdВетеринара { get; set; }

    public int IdКлиники { get; set; }

    public DateTime ДатаВизита { get; set; }

    public string? Причина { get; set; }

    public string? Диагноз { get; set; }

    public string? Лечение { get; set; }

    public decimal? Стоимость { get; set; }

    public string? Рекомендации { get; set; }

    public virtual ВетеринарныеКлиники IdКлиникиNavigation { get; set; } = null!;

    public virtual Питомцы IdПитомцаNavigation { get; set; } = null!;
}
