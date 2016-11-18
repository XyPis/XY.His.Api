using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.BS.Mapping
{
    public class BsLocationMap : EntityTypeConfiguration<BsLocation>
    {
        public BsLocationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.PhoneCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.BaSysCode)
                .HasMaxLength(50);

            this.Property(t => t.Director)
                .HasMaxLength(50);

            this.Property(t => t.PyCode)
                .HasMaxLength(10);

            this.Property(t => t.WbCode)
                .HasMaxLength(6);

            this.Property(t => t.F5)
                .HasMaxLength(100);

            this.Property(t => t.F6)
                .HasMaxLength(100);

            this.Property(t => t.F7)
                .HasMaxLength(100);

            this.Property(t => t.F8)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsLocation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.LsInOut).HasColumnName("LsInOut");
            this.Property(t => t.IsForwomen).HasColumnName("IsForwomen");
            this.Property(t => t.PhoneCode).HasColumnName("PhoneCode");
            this.Property(t => t.MedicineRatio).HasColumnName("MedicineRatio");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.SpecialityId).HasColumnName("SpecialityId");
            this.Property(t => t.BedSum).HasColumnName("BedSum");
            this.Property(t => t.BaSysCode).HasColumnName("BaSysCode");
            this.Property(t => t.Director).HasColumnName("Director");
            this.Property(t => t.DeptTypeId).HasColumnName("DeptTypeId");
            this.Property(t => t.IsCostApp).HasColumnName("IsCostApp");
            this.Property(t => t.AppLevel).HasColumnName("AppLevel");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.F8).HasColumnName("F8");
            this.Property(t => t.OuRoomId).HasColumnName("OuRoomId");
            this.Property(t => t.InRoomId).HasColumnName("InRoomId");
            this.Property(t => t.IsPriceSub).HasColumnName("IsPriceSub");

            // Relationships
        }
    }
}
