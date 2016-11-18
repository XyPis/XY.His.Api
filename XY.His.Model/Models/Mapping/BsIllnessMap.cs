using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsIllnessMap : EntityTypeConfiguration<BsIllness>
    {
        public BsIllnessMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
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

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsIllness");
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

            // Relationships
            this.HasOptional(t => t.BsIllness0)
                .WithMany(t => t.BsIllnesses)
                .HasForeignKey(d => d.BelongIcd);
            this.HasOptional(t => t.BsIllness2)
                .WithMany(t => t.BsIllness1)
                .HasForeignKey(d => d.BelongIcd);

        }
    }
}
