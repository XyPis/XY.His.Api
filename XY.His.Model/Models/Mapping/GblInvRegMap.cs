using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblInvRegMap : EntityTypeConfiguration<GblInvReg>
    {
        public GblInvRegMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.InvType)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StartInvoNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.EndInvoNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GblInvReg");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InvType).HasColumnName("InvType");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.StartInvoNo).HasColumnName("StartInvoNo");
            this.Property(t => t.EndInvoNo).HasColumnName("EndInvoNo");
            this.Property(t => t.IsEnd).HasColumnName("IsEnd");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.GblInvRegs)
                .HasForeignKey(d => d.OperID);

        }
    }
}
