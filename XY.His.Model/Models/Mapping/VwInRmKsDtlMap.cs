using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInRmKsDtlMap : EntityTypeConfiguration<VwInRmKsDtl>
    {
        public VwInRmKsDtlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.ItemId, t.Totality, t.UnitId, t.HospId, t.Name, t.PriceIn, t.Amount, t.ExecLocId, t.ExecOperId, t.OperTime, t.OperId, t.LocationName, t.InPatNo, t.Spec, t.BsUserName, t.BsUserID, t.PatientName, t.RoomId });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PriceIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExecLocId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExecOperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BsUserName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.BsUserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.RoomId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwInRmKsDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.ExecOperId).HasColumnName("ExecOperId");
            this.Property(t => t.IsPoison).HasColumnName("IsPoison");
            this.Property(t => t.IsMental).HasColumnName("IsMental");
            this.Property(t => t.IsExpen).HasColumnName("IsExpen");
            this.Property(t => t.LsImport).HasColumnName("LsImport");
            this.Property(t => t.IsInject).HasColumnName("IsInject");
            this.Property(t => t.IsSpecial).HasColumnName("IsSpecial");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.BsUserName).HasColumnName("BsUserName");
            this.Property(t => t.BsUserID).HasColumnName("BsUserID");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.SignTime).HasColumnName("SignTime");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
        }
    }
}
