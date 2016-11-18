using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OpsManMap : EntityTypeConfiguration<OpsMan>
    {
        public OpsManMap()
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

            this.Property(t => t.Memo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OpsMan");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ApplyId).HasColumnName("ApplyId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.LsRole).HasColumnName("LsRole");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DocLevId).HasColumnName("DocLevId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Memo).HasColumnName("Memo");

            // Relationships
            this.HasOptional(t => t.BsDocLevel)
                .WithMany(t => t.OpsMen)
                .HasForeignKey(d => d.DocLevId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.OpsMen)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.OpsMen)
                .HasForeignKey(d => d.UserId);
            this.HasRequired(t => t.OpsApply)
                .WithMany(t => t.OpsMen)
                .HasForeignKey(d => d.ApplyId);

        }
    }
}
