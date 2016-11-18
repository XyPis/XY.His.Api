using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuDocRegTypeMap : EntityTypeConfiguration<OuDocRegType>
    {
        public OuDocRegTypeMap()
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
            this.ToTable("OuDocRegType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RegDate).HasColumnName("RegDate");
            this.Property(t => t.WeekPlanId).HasColumnName("WeekPlanId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.RegTypeId).HasColumnName("RegTypeId");
            this.Property(t => t.TimeSpanId).HasColumnName("TimeSpanId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DiagRoomId).HasColumnName("DiagRoomId");
            this.Property(t => t.LimitNum).HasColumnName("LimitNum");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsDiagRoom)
                .WithMany(t => t.OuDocRegTypes)
                .HasForeignKey(d => d.DiagRoomId);
            this.HasRequired(t => t.BsDoctor)
                .WithMany(t => t.OuDocRegTypes)
                .HasForeignKey(d => d.DoctorId);
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.OuDocRegTypes)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsRegType)
                .WithMany(t => t.OuDocRegTypes)
                .HasForeignKey(d => d.RegTypeId);

        }
    }
}
