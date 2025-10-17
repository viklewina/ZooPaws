using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class КатегорииУхода
{
    public int IdКатегории { get; set; }

    public string НазваниеКатегории { get; set; } = null!;

    public string? ОписаниеКатегории { get; set; }

    public virtual ICollection<СтатьиПоУходу> СтатьиПоУходуs { get; set; } = new List<СтатьиПоУходу>();
}
