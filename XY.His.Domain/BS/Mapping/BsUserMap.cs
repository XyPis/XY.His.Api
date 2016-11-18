using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.BS.Mapping
{
    public class BsUserMap : EntityTypeConfiguration<BsUser>
    {
        public BsUserMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.Reason)
                .HasMaxLength(12);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.PicturePath)
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .HasMaxLength(40);

            this.Property(t => t.Mobile)
                .HasMaxLength(30);

            this.Property(t => t.F5)
                .HasMaxLength(100);

            this.Property(t => t.CertIdNo)
                .HasMaxLength(100);

            this.Property(t => t.PyCode)
                .HasMaxLength(30);

            this.Property(t => t.WbCode)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("BsUser");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.LsInputWay).HasColumnName("LsInputWay");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.IsUserInputWB).HasColumnName("IsUserInputWB");
            this.Property(t => t.IsUserInputPY).HasColumnName("IsUserInputPY");
            this.Property(t => t.IsUserInputCode).HasColumnName("IsUserInputCode");
            this.Property(t => t.IsUserInputName).HasColumnName("IsUserInputName");
            this.Property(t => t.IsUserInputStrokeCode).HasColumnName("IsUserInputStrokeCode");
            this.Property(t => t.IsUserInputEngDesc).HasColumnName("IsUserInputEngDesc");
            this.Property(t => t.Introduce).HasColumnName("Introduce");
            this.Property(t => t.PicturePath).HasColumnName("PicturePath");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.LevelId).HasColumnName("LevelId");
            this.Property(t => t.DocLevId).HasColumnName("DocLevId");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.CareGroupId).HasColumnName("CareGroupId");
            this.Property(t => t.CareGroupId1).HasColumnName("CareGroupId1");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.CertIdNo).HasColumnName("CertIdNo");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.IsUserInputF1).HasColumnName("IsUserInputF1");

            // Relationships           

        }
    }
}
