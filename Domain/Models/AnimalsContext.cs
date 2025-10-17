using System;
using System.Collections.Generic;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models;

public partial class AnimalsContext : DbContext
{
    public AnimalsContext()
    {
    }

    public AnimalsContext(DbContextOptions<AnimalsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ВакцинацииПитомцев> ВакцинацииПитомцевs { get; set; }

    public virtual DbSet<Вакцины> Вакциныs { get; set; }

    public virtual DbSet<ВетеринарныеВизиты> ВетеринарныеВизитыs { get; set; }

    public virtual DbSet<ВетеринарныеКлиники> ВетеринарныеКлиникиs { get; set; }

    public virtual DbSet<КатегорииУхода> КатегорииУходаs { get; set; }

    public virtual DbSet<Корма> Кормаs { get; set; }

    public virtual DbSet<Питомцы> Питомцыs { get; set; }

    public virtual DbSet<Пользователи> Пользователиs { get; set; }

    public virtual DbSet<Породы> Породыs { get; set; }

    public virtual DbSet<РационПитомцев> РационПитомцевs { get; set; }

    public virtual DbSet<СтатьиПоУходу> СтатьиПоУходуs { get; set; }

    public virtual DbSet<ТипыЖивотных> ТипыЖивотныхs { get; set; }

 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ВакцинацииПитомцев>(entity =>
        {
            entity.HasKey(e => e.IdВакцинации).HasName("PK__Вакцинац__F952686293F06AB6");

            entity.ToTable("ВакцинацииПитомцев");

            entity.HasIndex(e => e.IdВакцины, "IX_Вакцинации_Вакцина");

            entity.HasIndex(e => e.IdКлиники, "IX_Вакцинации_Клиника");

            entity.HasIndex(e => e.IdПитомца, "IX_Вакцинации_Питомец");

            entity.Property(e => e.IdВакцинации).HasColumnName("ID_вакцинации");
            entity.Property(e => e.IdВакцины).HasColumnName("ID_вакцины");
            entity.Property(e => e.IdКлиники).HasColumnName("ID_клиники");
            entity.Property(e => e.IdПитомца).HasColumnName("ID_питомца");
            entity.Property(e => e.Примечания).HasMaxLength(500);

            entity.HasOne(d => d.IdВакциныNavigation).WithMany(p => p.ВакцинацииПитомцевs)
                .HasForeignKey(d => d.IdВакцины)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Вакцинаци__ID_ва__5441852A");

            entity.HasOne(d => d.IdКлиникиNavigation).WithMany(p => p.ВакцинацииПитомцевs)
                .HasForeignKey(d => d.IdКлиники)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Вакцинаци__ID_кл__5535A963");

            entity.HasOne(d => d.IdПитомцаNavigation).WithMany(p => p.ВакцинацииПитомцевs)
                .HasForeignKey(d => d.IdПитомца)
                .HasConstraintName("FK__Вакцинаци__ID_пи__534D60F1");
        });

        modelBuilder.Entity<Вакцины>(entity =>
        {
            entity.HasKey(e => e.IdВакцины).HasName("PK__Вакцины__26061E8881FC5A1F");

            entity.ToTable("Вакцины");

            entity.Property(e => e.IdВакцины).HasColumnName("ID_вакцины");
            entity.Property(e => e.НазваниеВакцины).HasMaxLength(200);
            entity.Property(e => e.ОписаниеВакцины).HasMaxLength(500);
        });

        modelBuilder.Entity<ВетеринарныеВизиты>(entity =>
        {
            entity.HasKey(e => e.IdВизита).HasName("PK__Ветерина__BCADEFE8C5DA4191");

            entity.ToTable("ВетеринарныеВизиты");

            entity.HasIndex(e => e.IdВетеринара, "IX_Визиты_Ветеринар");

            entity.HasIndex(e => e.IdКлиники, "IX_Визиты_Клиника");

            entity.HasIndex(e => e.IdПитомца, "IX_Визиты_Питомец");

            entity.Property(e => e.IdВизита).HasColumnName("ID_визита");
            entity.Property(e => e.IdВетеринара).HasColumnName("ID_ветеринара");
            entity.Property(e => e.IdКлиники).HasColumnName("ID_клиники");
            entity.Property(e => e.IdПитомца).HasColumnName("ID_питомца");
            entity.Property(e => e.Диагноз).HasMaxLength(1000);
            entity.Property(e => e.Лечение).HasMaxLength(1000);
            entity.Property(e => e.Причина).HasMaxLength(500);
            entity.Property(e => e.Рекомендации).HasMaxLength(1000);
            entity.Property(e => e.Стоимость).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdКлиникиNavigation).WithMany(p => p.ВетеринарныеВизитыs)
                .HasForeignKey(d => d.IdКлиники)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ветеринар__ID_кл__59063A47");

            entity.HasOne(d => d.IdПитомцаNavigation).WithMany(p => p.ВетеринарныеВизитыs)
                .HasForeignKey(d => d.IdПитомца)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ветеринар__ID_пи__5812160E");
        });

        modelBuilder.Entity<ВетеринарныеКлиники>(entity =>
        {
            entity.HasKey(e => e.IdКлиники).HasName("PK__Ветерина__99E16B08B1762F14");

            entity.ToTable("ВетеринарныеКлиники");

            entity.Property(e => e.IdКлиники).HasColumnName("ID_клиники");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Адрес).HasMaxLength(500);
            entity.Property(e => e.Название).HasMaxLength(200);
            entity.Property(e => e.Рейтинг).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.Телефон).HasMaxLength(20);
        });

        modelBuilder.Entity<КатегорииУхода>(entity =>
        {
            entity.HasKey(e => e.IdКатегории).HasName("PK__Категори__ECF69440DDB171B3");

            entity.ToTable("КатегорииУхода");

            entity.Property(e => e.IdКатегории).HasColumnName("ID_категории");
            entity.Property(e => e.НазваниеКатегории).HasMaxLength(100);
            entity.Property(e => e.ОписаниеКатегории).HasMaxLength(500);
        });

        modelBuilder.Entity<Корма>(entity =>
        {
            entity.HasKey(e => e.IdКорма).HasName("PK__Корма__6816E1ED132DFD7B");

            entity.ToTable("Корма");

            entity.Property(e => e.IdКорма).HasColumnName("ID_корма");
            entity.Property(e => e.ВозрастнаяГруппа).HasMaxLength(100);
            entity.Property(e => e.НазваниеКорма).HasMaxLength(200);
            entity.Property(e => e.ОписаниеКорма).HasMaxLength(500);
            entity.Property(e => e.Производитель).HasMaxLength(150);
            entity.Property(e => e.ТипКорма).HasMaxLength(100);
        });

        modelBuilder.Entity<Питомцы>(entity =>
        {
            entity.HasKey(e => e.IdПитомца).HasName("PK__Питомцы__0C615271D45B9408");

            entity.ToTable("Питомцы");

            entity.HasIndex(e => e.IdПользователя, "IX_Питомцы_Пользователь");

            entity.HasIndex(e => e.IdПороды, "IX_Питомцы_Порода");

            entity.Property(e => e.IdПитомца).HasColumnName("ID_питомца");
            entity.Property(e => e.IdПользователя).HasColumnName("ID_пользователя");
            entity.Property(e => e.IdПороды).HasColumnName("ID_породы");
            entity.Property(e => e.Вес).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ДатаДобавления)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Кличка).HasMaxLength(100);
            entity.Property(e => e.Пол).HasMaxLength(10);

            entity.HasOne(d => d.IdПользователяNavigation).WithMany(p => p.Питомцыs)
                .HasForeignKey(d => d.IdПользователя)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Питомцы__ID_поль__403A8C7D");

            entity.HasOne(d => d.IdПородыNavigation).WithMany(p => p.Питомцыs)
                .HasForeignKey(d => d.IdПороды)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Питомцы__ID_поро__412EB0B6");
        });

        modelBuilder.Entity<Пользователи>(entity =>
        {
            entity.HasKey(e => e.IdПользователя).HasName("PK__Пользова__B1AC0CDE89CD4C46");

            entity.ToTable("Пользователи");

            entity.HasIndex(e => e.Email, "UQ__Пользова__A9D1053489030C2F").IsUnique();

            entity.Property(e => e.IdПользователя).HasColumnName("ID_пользователя");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Имя).HasMaxLength(100);
            entity.Property(e => e.Пароль).HasMaxLength(255);
            entity.Property(e => e.Фамилия).HasMaxLength(100);
        });

        modelBuilder.Entity<Породы>(entity =>
        {
            entity.HasKey(e => e.IdПороды).HasName("PK__Породы__0B04BE2C63C10CB9");

            entity.ToTable("Породы");

            entity.Property(e => e.IdПороды).HasColumnName("ID_породы");
            entity.Property(e => e.IdТипа).HasColumnName("ID_типа");
            entity.Property(e => e.НазваниеПороды).HasMaxLength(150);
            entity.Property(e => e.Размер).HasMaxLength(50);
            entity.Property(e => e.СтранаПроисхождения).HasMaxLength(100);
            entity.Property(e => e.УровеньАктивности).HasMaxLength(50);

            entity.HasOne(d => d.IdТипаNavigation).WithMany(p => p.Породыs)
                .HasForeignKey(d => d.IdТипа)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Породы__ID_типа__398D8EEE");
        });

        modelBuilder.Entity<РационПитомцев>(entity =>
        {
            entity.HasKey(e => e.IdРациона).HasName("PK__РационПи__1A47F5E67A509D9B");

            entity.ToTable("РационПитомцев");

            entity.HasIndex(e => e.IdПитомца, "IX_Рацион_Питомец");

            entity.Property(e => e.IdРациона).HasColumnName("ID_рациона");
            entity.Property(e => e.IdКорма).HasColumnName("ID_корма");
            entity.Property(e => e.IdПитомца).HasColumnName("ID_питомца");
            entity.Property(e => e.КоличествоВдень)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("КоличествоВДень");

            entity.HasOne(d => d.IdКормаNavigation).WithMany(p => p.РационПитомцевs)
                .HasForeignKey(d => d.IdКорма)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__РационПит__ID_ко__4E88ABD4");

            entity.HasOne(d => d.IdПитомцаNavigation).WithMany(p => p.РационПитомцевs)
                .HasForeignKey(d => d.IdПитомца)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__РационПит__ID_пи__4D94879B");
        });

        modelBuilder.Entity<СтатьиПоУходу>(entity =>
        {
            entity.HasKey(e => e.IdСтатьи).HasName("PK__СтатьиПо__DB4BD65391F15273");

            entity.ToTable("СтатьиПоУходу");

            entity.HasIndex(e => e.IdКатегории, "IX_Статьи_Категория");

            entity.HasIndex(e => e.IdТипа, "IX_Статьи_Тип");

            entity.Property(e => e.IdСтатьи).HasColumnName("ID_статьи");
            entity.Property(e => e.IdКатегории).HasColumnName("ID_категории");
            entity.Property(e => e.IdТипа).HasColumnName("ID_типа");
            entity.Property(e => e.Заголовок).HasMaxLength(255);
            entity.Property(e => e.УровеньСложности).HasMaxLength(50);

            entity.HasOne(d => d.IdКатегорииNavigation).WithMany(p => p.СтатьиПоУходуs)
                .HasForeignKey(d => d.IdКатегории)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__СтатьиПоУ__ID_ка__45F365D3");

            entity.HasOne(d => d.IdТипаNavigation).WithMany(p => p.СтатьиПоУходуs)
                .HasForeignKey(d => d.IdТипа)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__СтатьиПоУ__ID_ти__46E78A0C");
        });

        modelBuilder.Entity<ТипыЖивотных>(entity =>
        {
            entity.HasKey(e => e.IdТипа).HasName("PK__ТипыЖиво__6DB28E03BEDD3E05");

            entity.ToTable("ТипыЖивотных");

            entity.Property(e => e.IdТипа).HasColumnName("ID_типа");
            entity.Property(e => e.НазваниеТипа).HasMaxLength(100);
            entity.Property(e => e.ОписаниеТипа).HasMaxLength(500);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
