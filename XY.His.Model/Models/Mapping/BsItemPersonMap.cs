using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsItemPersonMap : EntityTypeConfiguration<BsItemPerson>
    {
        public BsItemPersonMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(200);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsItemPerson");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.FromTime).HasColumnName("FromTime");
            this.Property(t => t.ToTime).HasColumnName("ToTime");
            this.Property(t => t.IsExcept).HasColumnName("IsExcept");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.BsItemPersons)
                .HasForeignKey(d => d.ItemId);
            this.HasOptional(t => t.BsPatient)
                .WithMany(t => t.BsItemPersons)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.BsItemPersons)
                .HasForeignKey(d => d.UserId);

        }
    }
}
