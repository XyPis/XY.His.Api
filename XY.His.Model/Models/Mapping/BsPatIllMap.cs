using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsPatIllMap : EntityTypeConfiguration<BsPatIll>
    {
        public BsPatIllMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.IllDesc)
                .HasMaxLength(100);

            this.Property(t => t.ConfirmDoctor)
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
            this.ToTable("BsPatIll");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.IcdId).HasColumnName("IcdId");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.LsWestChin).HasColumnName("LsWestChin");
            this.Property(t => t.IllTime).HasColumnName("IllTime");
            this.Property(t => t.ConfirmDoctor).HasColumnName("ConfirmDoctor");
            this.Property(t => t.LsEffect).HasColumnName("LsEffect");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsIllness)
                .WithMany(t => t.BsPatIlls)
                .HasForeignKey(d => d.IcdId);
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.BsPatIlls)
                .HasForeignKey(d => d.PatId);
            this.HasOptional(t => t.BsUser)
                .WithMany(t => t.BsPatIlls)
                .HasForeignKey(d => d.OperID);

        }
    }
}
