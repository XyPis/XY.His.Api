using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InHosMzIllMap : EntityTypeConfiguration<InHosMzIll>
    {
        public InHosMzIllMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.IllDesc)
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

            this.Property(t => t.F5)
                .HasMaxLength(100);

            this.Property(t => t.F6)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("InHosMzIll");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.IcdId).HasColumnName("IcdId");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.LsInOut).HasColumnName("LsInOut");
            this.Property(t => t.LsWestChin).HasColumnName("LsWestChin");
            this.Property(t => t.IsInfect).HasColumnName("IsInfect");
            this.Property(t => t.IsCoincidence).HasColumnName("IsCoincidence");
            this.Property(t => t.CheckOperId).HasColumnName("CheckOperId");
            this.Property(t => t.CheckTime).HasColumnName("CheckTime");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");

            // Relationships
            this.HasOptional(t => t.BsIllness)
                .WithMany(t => t.InHosMzIlls)
                .HasForeignKey(d => d.IcdId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InHosMzIlls)
                .HasForeignKey(d => d.HospId);
            this.HasRequired(t => t.InHosInfo1)
                .WithMany(t => t.InHosMzIlls1)
                .HasForeignKey(d => d.HospId);

        }
    }
}
