using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class ВакцинацииПитомцев
{
    public int IdВакцинации { get; set; }

    public int IdПитомца { get; set; }

    public int IdВакцины { get; set; }

    public int IdКлиники { get; set; }

    public DateOnly ДатаВакцинации { get; set; }

    public string? Примечания { get; set; }

    public virtual Вакцины IdВакциныNavigation { get; set; } = null!;

    public virtual ВетеринарныеКлиники IdКлиникиNavigation { get; set; } = null!;

    public virtual Питомцы IdПитомцаNavigation { get; set; } = null!;
}
