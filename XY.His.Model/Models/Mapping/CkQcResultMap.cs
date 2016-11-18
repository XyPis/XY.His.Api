using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkQcResultMap : EntityTypeConfiguration<CkQcResult>
    {
        public CkQcResultMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Result)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ResultComment)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ResultStatus)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.RejectMemo)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(50);

            this.Property(t => t.F2)
                .HasMaxLength(50);

            this.Property(t => t.F3)
                .HasMaxLength(50);

            this.Property(t => t.F4)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CkQcResult");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ResultDate).HasColumnName("ResultDate");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.ResultComment).HasColumnName("ResultComment");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.ResultStatus).HasColumnName("ResultStatus");
            this.Property(t => t.LotId).HasColumnName("LotId");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.CtrlId).HasColumnName("CtrlId");
            this.Property(t => t.IsShowQc).HasColumnName("IsShowQc");
            this.Property(t => t.RejectMemo).HasColumnName("RejectMemo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.CkQcResults)
                .HasForeignKey(d => d.OperId);
            this.HasRequired(t => t.CkQcControl)
                .WithMany(t => t.CkQcResults)
                .HasForeignKey(d => d.CtrlId);
            this.HasRequired(t => t.CkQcLot)
                .WithMany(t => t.CkQcResults)
                .HasForeignKey(d => d.LotId);

        }
    }
}
