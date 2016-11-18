using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class TrSchedulerMap : EntityTypeConfiguration<TrScheduler>
    {
        public TrSchedulerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TrScheduler");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.LineId).HasColumnName("LineId");
            this.Property(t => t.ScheTime).HasColumnName("ScheTime");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.TrSchedulers)
                .HasForeignKey(d => d.UserId);
            this.HasRequired(t => t.BsUser1)
                .WithMany(t => t.TrSchedulers1)
                .HasForeignKey(d => d.OperId);
            this.HasRequired(t => t.TrScheLine)
                .WithMany(t => t.TrSchedulers)
                .HasForeignKey(d => d.LineId);

        }
    }
}
