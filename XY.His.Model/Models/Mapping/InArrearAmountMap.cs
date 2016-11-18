using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InArrearAmountMap : EntityTypeConfiguration<InArrearAmount>
    {
        public InArrearAmountMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.AuthMan)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
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
            this.ToTable("InArrearAmount");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.ArrearAmount).HasColumnName("ArrearAmount");
            this.Property(t => t.AuthMan).HasColumnName("AuthMan");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.ExpireDate).HasColumnName("ExpireDate");
            this.Property(t => t.ExpireHours).HasColumnName("ExpireHours");
            this.Property(t => t.IsMax).HasColumnName("IsMax");

            // Relationships
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.InArrearAmounts)
                .HasForeignKey(d => d.OperID);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InArrearAmounts)
                .HasForeignKey(d => d.HospId);

        }
    }
}
