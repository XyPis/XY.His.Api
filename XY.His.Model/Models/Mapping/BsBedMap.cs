using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsBedMap : EntityTypeConfiguration<BsBed>
    {
        public BsBedMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RoomNo)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Memo)
                .HasMaxLength(20);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsBed");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.RoomNo).HasColumnName("RoomNo");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LsBALL).HasColumnName("LsBALL");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.IsAdd).HasColumnName("IsAdd");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.LsClass).HasColumnName("LsClass");
            this.Property(t => t.IsAddBed).HasColumnName("IsAddBed");

            // Relationships
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.BsBeds)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.BsItem)
                .WithMany(t => t.BsBeds)
                .HasForeignKey(d => d.ItemId);

        }
    }
}
