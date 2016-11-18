using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RmCheckGroupDtlMap : EntityTypeConfiguration<RmCheckGroupDtl>
    {
        public RmCheckGroupDtlMap()
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
            this.ToTable("RmCheckGroupDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CheckId).HasColumnName("CheckId");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.InBatchId).HasColumnName("InBatchId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.CheckNum).HasColumnName("CheckNum");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.RmCheckGroupDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsRoomGroup)
                .WithMany(t => t.RmCheckGroupDtls)
                .HasForeignKey(d => d.GroupId);
            this.HasRequired(t => t.RmCheck)
                .WithMany(t => t.RmCheckGroupDtls)
                .HasForeignKey(d => d.CheckId);
            this.HasRequired(t => t.Rmstore)
                .WithMany(t => t.RmCheckGroupDtls)
                .HasForeignKey(d => d.InBatchId);

        }
    }
}
