using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class СтатьиПоУходу
{
    public int IdСтатьи { get; set; }

    public int IdКатегории { get; set; }

    public int IdТипа { get; set; }

    public string Заголовок { get; set; } = null!;

    public string? Содержание { get; set; }

    public string? УровеньСложности { get; set; }

    public virtual КатегорииУхода IdКатегорииNavigation { get; set; } = null!;

    public virtual ТипыЖивотных IdТипаNavigation { get; set; } = null!;
}
