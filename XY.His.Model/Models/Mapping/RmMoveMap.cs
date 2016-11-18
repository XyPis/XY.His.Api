using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RmMoveMap : EntityTypeConfiguration<RmMove>
    {
        public RmMoveMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("RmMove");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.RoomIdI).HasColumnName("RoomIdI");
            this.Property(t => t.RoomIdO).HasColumnName("RoomIdO");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.Operid).HasColumnName("Operid");
            this.Property(t => t.IsSign).HasColumnName("IsSign");
            this.Property(t => t.SignTime).HasColumnName("SignTime");
            this.Property(t => t.SignOperId).HasColumnName("SignOperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IsSignRev).HasColumnName("IsSignRev");
            this.Property(t => t.SignTimeRev).HasColumnName("SignTimeRev");
            this.Property(t => t.SignOperIdRev).HasColumnName("SignOperIdRev");

            // Relationships
            this.HasRequired(t => t.BsRoom)
                .WithMany(t => t.RmMoves)
                .HasForeignKey(d => d.RoomIdI);
            this.HasRequired(t => t.BsRoom1)
                .WithMany(t => t.RmMoves1)
                .HasForeignKey(d => d.RoomIdO);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.RmMoves)
                .HasForeignKey(d => d.Operid);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.RmMoves1)
                .HasForeignKey(d => d.SignOperIdRev);

        }
    }
}
