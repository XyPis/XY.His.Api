using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RTRJKREPORTMap : EntityTypeConfiguration<RTRJKREPORT>
    {
        public RTRJKREPORTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.operid, t.opertime, t.IsSign });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.operid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsOutIn)
                .HasMaxLength(10);

            this.Property(t => t.Memo)
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("RTRJKREPORT");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.operid).HasColumnName("operid");
            this.Property(t => t.opertime).HasColumnName("opertime");
            this.Property(t => t.cancelopertime).HasColumnName("cancelopertime");
            this.Property(t => t.iscancel).HasColumnName("iscancel");
            this.Property(t => t.begintime).HasColumnName("begintime");
            this.Property(t => t.endtime).HasColumnName("endtime");
            this.Property(t => t.hospitalid).HasColumnName("hospitalid");
            this.Property(t => t.LsOutIn).HasColumnName("LsOutIn");
            this.Property(t => t.bills).HasColumnName("bills");
            this.Property(t => t.billcancel).HasColumnName("billcancel");
            this.Property(t => t.AmountSum).HasColumnName("AmountSum");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.AmountCancel).HasColumnName("AmountCancel");
            this.Property(t => t.Insurance).HasColumnName("Insurance");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.AmountYF).HasColumnName("AmountYF");
            this.Property(t => t.IsSign).HasColumnName("IsSign");
            this.Property(t => t.SignTime).HasColumnName("SignTime");
            this.Property(t => t.SignOperId).HasColumnName("SignOperId");
            this.Property(t => t.Memo).HasColumnName("Memo");
        }
    }
}
