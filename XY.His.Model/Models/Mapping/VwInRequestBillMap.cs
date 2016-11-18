using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInRequestBillMap : EntityTypeConfiguration<VwInRequestBill>
    {
        public VwInRequestBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RequestID, t.ListNum, t.LocationID, t.HospID, t.HospNO, t.PatName, t.LsMarkType, t.GroupNum, t.AdviceID, t.ItemID, t.ItemName, t.Spec, t.Totality, t.UnitReq, t.UnitName, t.IsIssued, t.RoomID, t.LsExecLoc });

            // Properties
            this.Property(t => t.RequestID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ListNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.HospID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospNO)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.BedName)
                .HasMaxLength(10);

            this.Property(t => t.PatName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.LsMarkType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.GroupNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AdviceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitReq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RoomID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomName)
                .HasMaxLength(50);

            this.Property(t => t.LsExecLoc)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwInRequestBill");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.fordate).HasColumnName("fordate");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.HospID).HasColumnName("HospID");
            this.Property(t => t.HospNO).HasColumnName("HospNO");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.PatName).HasColumnName("PatName");
            this.Property(t => t.LsMarkType).HasColumnName("LsMarkType");
            this.Property(t => t.DoctorID).HasColumnName("DoctorID");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.AdviceID).HasColumnName("AdviceID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitReq).HasColumnName("UnitReq");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.IsIssued).HasColumnName("IsIssued");
            this.Property(t => t.RoomID).HasColumnName("RoomID");
            this.Property(t => t.RoomName).HasColumnName("RoomName");
            this.Property(t => t.LsExecLoc).HasColumnName("LsExecLoc");
            this.Property(t => t.BackedNum).HasColumnName("BackedNum");
            this.Property(t => t.BackNum).HasColumnName("BackNum");
            this.Property(t => t.BackSeq).HasColumnName("BackSeq");
            this.Property(t => t.IsBack).HasColumnName("IsBack");
        }
    }
}
