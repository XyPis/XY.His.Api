using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElTipMap : EntityTypeConfiguration<ElTip>
    {
        public ElTipMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.WhereFormat)
                .HasMaxLength(50);

            this.Property(t => t.Arg1)
                .HasMaxLength(50);

            this.Property(t => t.Arg2)
                .HasMaxLength(50);

            this.Property(t => t.Arg3)
                .HasMaxLength(50);

            this.Property(t => t.Arg4)
                .HasMaxLength(50);

            this.Property(t => t.Arg5)
                .HasMaxLength(50);

            this.Property(t => t.Tips)
                .HasMaxLength(500);

            this.Property(t => t.RoleIds)
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
            this.ToTable("ElTips");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatMenuId).HasColumnName("PatMenuId");
            this.Property(t => t.WhereFormat).HasColumnName("WhereFormat");
            this.Property(t => t.Arg1).HasColumnName("Arg1");
            this.Property(t => t.Arg2).HasColumnName("Arg2");
            this.Property(t => t.Arg3).HasColumnName("Arg3");
            this.Property(t => t.Arg4).HasColumnName("Arg4");
            this.Property(t => t.Arg5).HasColumnName("Arg5");
            this.Property(t => t.Tips).HasColumnName("Tips");
            this.Property(t => t.IsFollow).HasColumnName("IsFollow");
            this.Property(t => t.ActiveDays).HasColumnName("ActiveDays");
            this.Property(t => t.RoleIds).HasColumnName("RoleIds");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.GblPatientMenu)
                .WithMany(t => t.ElTips)
                .HasForeignKey(d => d.PatMenuId);

        }
    }
}
