using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class ТипыЖивотных
{
    public int IdТипа { get; set; }

    public string НазваниеТипа { get; set; } = null!;

    public string? ОписаниеТипа { get; set; }

    public virtual ICollection<Породы> Породыs { get; set; } = new List<Породы>();

    public virtual ICollection<СтатьиПоУходу> СтатьиПоУходуs { get; set; } = new List<СтатьиПоУходу>();
}
