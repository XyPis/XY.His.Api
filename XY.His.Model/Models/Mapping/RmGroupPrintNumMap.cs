using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RmGroupPrintNumMap : EntityTypeConfiguration<RmGroupPrintNum>
    {
        public RmGroupPrintNumMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("RmGroupPrintNum");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PrintDate).HasColumnName("PrintDate");
            this.Property(t => t.Group1PageNum).HasColumnName("Group1PageNum");
            this.Property(t => t.Group2PageNum).HasColumnName("Group2PageNum");
            this.Property(t => t.Group3PageNum).HasColumnName("Group3PageNum");
            this.Property(t => t.Group4PageNum).HasColumnName("Group4PageNum");
            this.Property(t => t.Group5PageNum).HasColumnName("Group5PageNum");
            this.Property(t => t.Group6PageNum).HasColumnName("Group6PageNum");
            this.Property(t => t.PreviousGroup1PageNum).HasColumnName("PreviousGroup1PageNum");
            this.Property(t => t.PreviousGroup2PageNum).HasColumnName("PreviousGroup2PageNum");
            this.Property(t => t.PreviousGroup3PageNum).HasColumnName("PreviousGroup3PageNum");
            this.Property(t => t.PreviousGroup4PageNum).HasColumnName("PreviousGroup4PageNum");
            this.Property(t => t.PreviousGroup5PageNum).HasColumnName("PreviousGroup5PageNum");
            this.Property(t => t.PreviousGroup6PageNum).HasColumnName("PreviousGroup6PageNum");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
