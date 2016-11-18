using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsDoctorMap : EntityTypeConfiguration<BsDoctor>
    {
        public BsDoctorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
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

            this.Property(t => t.PicturePath)
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

            this.Property(t => t.PyCode)
                .HasMaxLength(6);

            this.Property(t => t.WbCode)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("BsDoctor");
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
            this.Property(t => t.DiagRoomID).HasColumnName("DiagRoomID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");

            // Relationships
            this.HasOptional(t => t.BsDocLevel)
                .WithMany(t => t.BsDoctors)
                .HasForeignKey(d => d.DocLevId);
            this.HasOptional(t => t.BsDoctor2)
                .WithMany(t => t.BsDoctor1)
                .HasForeignKey(d => d.SupDoctorId);
            this.HasOptional(t => t.BsUser)
                .WithMany(t => t.BsDoctors)
                .HasForeignKey(d => d.UserId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.BsDoctors)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.BsRegType)
                .WithMany(t => t.BsDoctors)
                .HasForeignKey(d => d.RegTypeId);
            this.HasOptional(t => t.BsEduLevel)
                .WithMany(t => t.BsDoctors)
                .HasForeignKey(d => d.LevelId);

        }
    }
}
