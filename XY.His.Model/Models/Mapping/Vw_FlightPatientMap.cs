using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_FlightPatientMap : EntityTypeConfiguration<Vw_FlightPatient>
    {
        public Vw_FlightPatientMap()
        {
            // Primary Key
            this.HasKey(t => new { t.patID, t.Name, t.Sex, t.Native, t.IdCardNo, t.Identity, t.AddressHome, t.PostCodeHome, t.PhoneHome, t.PhoneWork, t.LinkmanName, t.LinkmanAddress, t.LinkmanPhone });

            // Properties
            this.Property(t => t.patID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InPatNo)
                .HasMaxLength(13);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Native)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CountryName)
                .HasMaxLength(50);

            this.Property(t => t.NationName)
                .HasMaxLength(50);

            this.Property(t => t.IdCardNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Identity)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.patTypeName)
                .HasMaxLength(50);

            this.Property(t => t.AddressHome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PostCodeHome)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.PhoneHome)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.PhoneWork)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.LinkmanName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RelationName)
                .HasMaxLength(50);

            this.Property(t => t.LinkmanAddress)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LinkmanPost)
                .HasMaxLength(50);

            this.Property(t => t.LinkmanPhone)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Vw_FlightPatient");
            this.Property(t => t.patID).HasColumnName("patID");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Native).HasColumnName("Native");
            this.Property(t => t.CountryName).HasColumnName("CountryName");
            this.Property(t => t.NationName).HasColumnName("NationName");
            this.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
            this.Property(t => t.Identity).HasColumnName("Identity");
            this.Property(t => t.patTypeName).HasColumnName("patTypeName");
            this.Property(t => t.AddressHome).HasColumnName("AddressHome");
            this.Property(t => t.PostCodeHome).HasColumnName("PostCodeHome");
            this.Property(t => t.PhoneHome).HasColumnName("PhoneHome");
            this.Property(t => t.PhoneWork).HasColumnName("PhoneWork");
            this.Property(t => t.LinkmanName).HasColumnName("LinkmanName");
            this.Property(t => t.RelationName).HasColumnName("RelationName");
            this.Property(t => t.LinkmanAddress).HasColumnName("LinkmanAddress");
            this.Property(t => t.LinkmanPost).HasColumnName("LinkmanPost");
            this.Property(t => t.LinkmanPhone).HasColumnName("LinkmanPhone");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Weight).HasColumnName("Weight");
        }
    }
}
