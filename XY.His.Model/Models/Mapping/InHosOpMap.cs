using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InHosOpMap : EntityTypeConfiguration<InHosOp>
    {
        public InHosOpMap()
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
            this.ToTable("InHosOps");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.OpsTimes).HasColumnName("OpsTimes");
            this.Property(t => t.OpsTime).HasColumnName("OpsTime");
            this.Property(t => t.OpsId).HasColumnName("OpsId");
            this.Property(t => t.LsCut).HasColumnName("LsCut");
            this.Property(t => t.LsRecove).HasColumnName("LsRecove");
            this.Property(t => t.OpsDoctorId).HasColumnName("OpsDoctorId");
            this.Property(t => t.AnaesId).HasColumnName("AnaesId");
            this.Property(t => t.AssistantOperId1).HasColumnName("AssistantOperId1");
            this.Property(t => t.AssistantOperId2).HasColumnName("AssistantOperId2");
            this.Property(t => t.AnaesDoctorId).HasColumnName("AnaesDoctorId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsAnae)
                .WithMany(t => t.InHosOps)
                .HasForeignKey(d => d.AnaesId);
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.InHosOps)
                .HasForeignKey(d => d.OpsDoctorId);
            this.HasOptional(t => t.BsDoctor1)
                .WithMany(t => t.InHosOps1)
                .HasForeignKey(d => d.AnaesDoctorId);
            this.HasOptional(t => t.BsOP)
                .WithMany(t => t.InHosOps)
                .HasForeignKey(d => d.OpsId);
            this.HasOptional(t => t.BsUser)
                .WithMany(t => t.InHosOps)
                .HasForeignKey(d => d.AssistantOperId1);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.InHosOps1)
                .HasForeignKey(d => d.AssistantOperId2);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InHosOps)
                .HasForeignKey(d => d.HospId);

        }
    }
}
