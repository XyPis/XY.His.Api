using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsOPMap : EntityTypeConfiguration<BsOP>
    {
        public BsOPMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(8);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PyCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsOPS");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.LsClass).HasColumnName("LsClass");
            this.Property(t => t.LsASA).HasColumnName("LsASA");
            this.Property(t => t.IsEmergency).HasColumnName("IsEmergency");
            this.Property(t => t.AnaesId).HasColumnName("AnaesId");
            this.Property(t => t.Minutes).HasColumnName("Minutes");
            this.Property(t => t.IsImplant).HasColumnName("IsImplant");
            this.Property(t => t.IsImglass).HasColumnName("IsImglass");
            this.Property(t => t.IsOPSDrug).HasColumnName("IsOPSDrug");
            this.Property(t => t.DangerPoint).HasColumnName("DangerPoint");

            // Relationships
            this.HasOptional(t => t.BsAnae)
                .WithMany(t => t.BsOPS)
                .HasForeignKey(d => d.AnaesId);

        }
    }
}
