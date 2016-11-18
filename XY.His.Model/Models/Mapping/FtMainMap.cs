using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class FtMainMap : EntityTypeConfiguration<FtMain>
    {
        public FtMainMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CheckNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Memo)
                .HasMaxLength(1000);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("FtMain");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CheckNo).HasColumnName("CheckNo");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.IsConfirm).HasColumnName("IsConfirm");
            this.Property(t => t.ConfirmOperTime).HasColumnName("ConfirmOperTime");
            this.Property(t => t.ConfirmOperID).HasColumnName("ConfirmOperID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsUser)
                .WithMany(t => t.FtMains)
                .HasForeignKey(d => d.UserId);

        }
    }
}
