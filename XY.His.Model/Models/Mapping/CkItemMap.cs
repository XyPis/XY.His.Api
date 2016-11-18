using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkItemMap : EntityTypeConfiguration<CkItem>
    {
        public CkItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShortName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OperMemo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.UseRange)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Format)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PrintHigh)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PrintLow)
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

            this.Property(t => t.TestWay)
                .HasMaxLength(50);

            this.Property(t => t.DefultValue)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("CkItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.LsTestType).HasColumnName("LsTestType");
            this.Property(t => t.TestTypeId).HasColumnName("TestTypeId");
            this.Property(t => t.TubeTypeId).HasColumnName("TubeTypeId");
            this.Property(t => t.ShortName).HasColumnName("ShortName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OperMemo).HasColumnName("OperMemo");
            this.Property(t => t.IsZero).HasColumnName("IsZero");
            this.Property(t => t.LsGroup).HasColumnName("LsGroup");
            this.Property(t => t.IsReport).HasColumnName("IsReport");
            this.Property(t => t.UseRange).HasColumnName("UseRange");
            this.Property(t => t.LsForSex).HasColumnName("LsForSex");
            this.Property(t => t.SourceId).HasColumnName("SourceId");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.Format).HasColumnName("Format");
            this.Property(t => t.LimitHigh).HasColumnName("LimitHigh");
            this.Property(t => t.LimitLow).HasColumnName("LimitLow");
            this.Property(t => t.PrintHigh).HasColumnName("PrintHigh");
            this.Property(t => t.PrintLow).HasColumnName("PrintLow");
            this.Property(t => t.DalAbsolute).HasColumnName("DalAbsolute");
            this.Property(t => t.DalPercent).HasColumnName("DalPercent");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsDisplay).HasColumnName("IsDisplay");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.FluidId).HasColumnName("FluidId");
            this.Property(t => t.TestWay).HasColumnName("TestWay");
            this.Property(t => t.Dev3).HasColumnName("Dev3");
            this.Property(t => t.Dev2).HasColumnName("Dev2");
            this.Property(t => t.Dev1).HasColumnName("Dev1");
            this.Property(t => t.DevM1).HasColumnName("DevM1");
            this.Property(t => t.DevM2).HasColumnName("DevM2");
            this.Property(t => t.DevM3).HasColumnName("DevM3");
            this.Property(t => t.AvgValue).HasColumnName("AvgValue");
            this.Property(t => t.DefultValue).HasColumnName("DefultValue");

            // Relationships
            this.HasOptional(t => t.BsFluid)
                .WithMany(t => t.CkItems)
                .HasForeignKey(d => d.FluidId);
            this.HasOptional(t => t.CkTestType)
                .WithMany(t => t.CkItems)
                .HasForeignKey(d => d.TestTypeId);

        }
    }
}
