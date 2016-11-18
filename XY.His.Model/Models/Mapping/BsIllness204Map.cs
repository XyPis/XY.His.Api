using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsIllness204Map : EntityTypeConfiguration<BsIllness204>
    {
        public BsIllness204Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Code, t.Name, t.GroupMain, t.GroupSub, t.GroupSSub, t.IsSum, t.OrderBy, t.IsActive, t.IconIndex });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.WbCode)
                .HasMaxLength(20);

            this.Property(t => t.PyCode)
                .HasMaxLength(20);

            this.Property(t => t.OtherCode)
                .HasMaxLength(4);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.OtherDesc)
                .HasMaxLength(255);

            this.Property(t => t.GroupMain)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GroupSub)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GroupSSub)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OrderBy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.IconIndex)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BsIllness204");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.OtherCode).HasColumnName("OtherCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OtherDesc).HasColumnName("OtherDesc");
            this.Property(t => t.GroupMain).HasColumnName("GroupMain");
            this.Property(t => t.GroupSub).HasColumnName("GroupSub");
            this.Property(t => t.GroupSSub).HasColumnName("GroupSSub");
            this.Property(t => t.BelongIcd).HasColumnName("BelongIcd");
            this.Property(t => t.IsSum).HasColumnName("IsSum");
            this.Property(t => t.FeeHigh).HasColumnName("FeeHigh");
            this.Property(t => t.DayHigh).HasColumnName("DayHigh");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.IsInfectious).HasColumnName("IsInfectious");
        }
    }
}
