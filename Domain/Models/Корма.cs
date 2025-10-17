using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Корма
{
    public int IdКорма { get; set; }

    public string НазваниеКорма { get; set; } = null!;

    public string? Производитель { get; set; }

    public string? ТипКорма { get; set; }

    public string? ВозрастнаяГруппа { get; set; }

    public string? ОписаниеКорма { get; set; }

    public virtual ICollection<РационПитомцев> РационПитомцевs { get; set; } = new List<РационПитомцев>();
}
