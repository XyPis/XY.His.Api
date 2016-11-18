using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CKMachineNoPassageMap : EntityTypeConfiguration<CKMachineNoPassage>
    {
        public CKMachineNoPassageMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PassAgeNum)
                .HasMaxLength(20);

            this.Property(t => t.TestResuslt)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CKMachineNoPassage");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.PassAgeNum).HasColumnName("PassAgeNum");
            this.Property(t => t.TestResuslt).HasColumnName("TestResuslt");
            this.Property(t => t.ResultDate).HasColumnName("ResultDate");
        }
    }
}
