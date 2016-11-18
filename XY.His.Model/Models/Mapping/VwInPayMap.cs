using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInPayMap : EntityTypeConfiguration<VwInPay>
    {
        public VwInPayMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.HospId, t.LsChargeType, t.Amount, t.Remain, t.PayWayId, t.Memo, t.OperTime, t.OperID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospNo)
                .HasMaxLength(20);

            this.Property(t => t.LsChargeType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsChargeTypeName)
                .HasMaxLength(12);

            this.Property(t => t.Amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Remain)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PayWayId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PayWayName)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.OperID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperName)
                .HasMaxLength(30);

            this.Property(t => t.BedName)
                .HasMaxLength(10);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.InPatNo)
                .HasMaxLength(13);

            this.Property(t => t.Sex)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SexName)
                .HasMaxLength(4);

            this.Property(t => t.LsInStatusName)
                .HasMaxLength(8);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwInPay");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.LsChargeType).HasColumnName("LsChargeType");
            this.Property(t => t.LsChargeTypeName).HasColumnName("LsChargeTypeName");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Remain).HasColumnName("Remain");
            this.Property(t => t.PayWayId).HasColumnName("PayWayId");
            this.Property(t => t.PayWayName).HasColumnName("PayWayName");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.PatID).HasColumnName("PatID");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.LsInStatus).HasColumnName("LsInStatus");
            this.Property(t => t.LsInStatusName).HasColumnName("LsInStatusName");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.TallyTypeName).HasColumnName("TallyTypeName");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.IsGf).HasColumnName("IsGf");
            this.Property(t => t.IsYb).HasColumnName("IsYb");
        }
    }
}
