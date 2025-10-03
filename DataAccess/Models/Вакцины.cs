using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Вакцины
{
    public int IdВакцины { get; set; }

    public string НазваниеВакцины { get; set; } = null!;

    public string? ОписаниеВакцины { get; set; }

    public int? ПериодичностьМесяцы { get; set; }

    public virtual ICollection<ВакцинацииПитомцев> ВакцинацииПитомцевs { get; set; } = new List<ВакцинацииПитомцев>();
}
