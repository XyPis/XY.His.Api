using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CKMachineMap : EntityTypeConfiguration<CKMachine>
    {
        public CKMachineMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MachineNum)
                .HasMaxLength(10);

            this.Property(t => t.FirstSampleNum)
                .HasMaxLength(14);

            this.Property(t => t.LastSampleNum)
                .HasMaxLength(14);

            this.Property(t => t.PyCode)
                .HasMaxLength(6);

            this.Property(t => t.WbCode)
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
            this.ToTable("CKMachine");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.TestTypeID).HasColumnName("TestTypeID");
            this.Property(t => t.TypeNum).HasColumnName("TypeNum");
            this.Property(t => t.MachineNum).HasColumnName("MachineNum");
            this.Property(t => t.FirstSampleNum).HasColumnName("FirstSampleNum");
            this.Property(t => t.LastSampleNum).HasColumnName("LastSampleNum");
            this.Property(t => t.SampleBeginDate).HasColumnName("SampleBeginDate");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
