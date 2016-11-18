using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RdContractMap : EntityTypeConfiguration<RdContract>
    {
        public RdContractMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("RdContract");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.IsTeach).HasColumnName("IsTeach");
            this.Property(t => t.IsMessage).HasColumnName("IsMessage");
            this.Property(t => t.IsEmail).HasColumnName("IsEmail");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.RdContracts)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.RdContracts)
                .HasForeignKey(d => d.OperID);

        }
    }
}
