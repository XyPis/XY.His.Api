using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class YBChargeLogMap : EntityTypeConfiguration<YBChargeLog>
    {
        public YBChargeLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.YbReqNo)
                .HasMaxLength(50);

            this.Property(t => t.InvoNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("YBChargeLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.YbReqNo).HasColumnName("YbReqNo");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
        }
    }
}
