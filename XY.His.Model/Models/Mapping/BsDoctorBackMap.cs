using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsDoctorBackMap : EntityTypeConfiguration<BsDoctorBack>
    {
        public BsDoctorBackMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Code, t.Name, t.Sex, t.Address, t.City, t.Mobile, t.Email, t.Introduce, t.LocationId, t.PicturePath, t.LsStatus, t.OrderBy, t.IconIndex });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Sex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Introduce)
                .IsRequired();

            this.Property(t => t.LocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PicturePath)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LsStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderBy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.IconIndex)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PyCode)
                .HasMaxLength(6);

            this.Property(t => t.WbCode)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("BsDoctorBack");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.LevelId).HasColumnName("LevelId");
            this.Property(t => t.DocLevId).HasColumnName("DocLevId");
            this.Property(t => t.Introduce).HasColumnName("Introduce");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.RegTypeId).HasColumnName("RegTypeId");
            this.Property(t => t.PicturePath).HasColumnName("PicturePath");
            this.Property(t => t.LsStatus).HasColumnName("LsStatus");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.SupDoctorId).HasColumnName("SupDoctorId");
        }
    }
}
