using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class TraceMap : EntityTypeConfiguration<Trace>
    {
        public TraceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.IP)
                .HasMaxLength(50);

            this.Property(t => t.Messages)
                .HasMaxLength(4000);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OperateType)
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

            // Table & Column Mappings
            this.ToTable("Trace");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.Messages).HasColumnName("Messages");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.OperateType).HasColumnName("OperateType");
            this.Property(t => t.RecordId).HasColumnName("RecordId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
