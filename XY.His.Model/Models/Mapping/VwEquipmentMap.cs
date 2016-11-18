using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwEquipmentMap : EntityTypeConfiguration<VwEquipment>
    {
        public VwEquipmentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.CODE, t.Name, t.CountryName, t.ManufacturerName, t.LocationName });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODE)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.EqType)
                .HasMaxLength(50);

            this.Property(t => t.SeriesNo)
                .HasMaxLength(50);

            this.Property(t => t.Brand)
                .HasMaxLength(50);

            this.Property(t => t.CountryName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ManufacturerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.LotNo)
                .HasMaxLength(50);

            this.Property(t => t.Manager)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwEquipment");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.EqType).HasColumnName("EqType");
            this.Property(t => t.SeriesNo).HasColumnName("SeriesNo");
            this.Property(t => t.Brand).HasColumnName("Brand");
            this.Property(t => t.CountryName).HasColumnName("CountryName");
            this.Property(t => t.ManufacturerName).HasColumnName("ManufacturerName");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.LsEqClass).HasColumnName("LsEqClass");
            this.Property(t => t.ManuId).HasColumnName("ManuId");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.LsEqStatus).HasColumnName("LsEqStatus");
            this.Property(t => t.LotNo).HasColumnName("LotNo");
            this.Property(t => t.Manager).HasColumnName("Manager");
            this.Property(t => t.BuyDate).HasColumnName("BuyDate");
            this.Property(t => t.UseLocId).HasColumnName("UseLocId");
        }
    }
}
