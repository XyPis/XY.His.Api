using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InNotAttachMap : EntityTypeConfiguration<InNotAttach>
    {
        public InNotAttachMap()
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
            this.ToTable("InNotAttach");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.ItemId1).HasColumnName("ItemId1");
            this.Property(t => t.ItemId2).HasColumnName("ItemId2");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.InNotAttaches)
                .HasForeignKey(d => d.ItemId1);
            this.HasRequired(t => t.BsItem1)
                .WithMany(t => t.InNotAttaches1)
                .HasForeignKey(d => d.ItemId2);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InNotAttaches)
                .HasForeignKey(d => d.HospId);

        }
    }
}
