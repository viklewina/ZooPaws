using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Породы
{
    public int IdПороды { get; set; }

    public int IdТипа { get; set; }

    public string НазваниеПороды { get; set; } = null!;

    public string? СтранаПроисхождения { get; set; }

    public string? Размер { get; set; }

    public string? УровеньАктивности { get; set; }

    public virtual ТипыЖивотных IdТипаNavigation { get; set; } = null!;

    public virtual ICollection<Питомцы> Питомцыs { get; set; } = new List<Питомцы>();
}
