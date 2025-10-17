using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class РационПитомцев
{
    public int IdРациона { get; set; }

    public int IdПитомца { get; set; }

    public int IdКорма { get; set; }

    public decimal? КоличествоВдень { get; set; }

    public TimeOnly? ВремяКормления { get; set; }

    public virtual Корма IdКормаNavigation { get; set; } = null!;

    public virtual Питомцы IdПитомцаNavigation { get; set; } = null!;
}
