using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElEhrMap : EntityTypeConfiguration<ElEhr>
    {
        public ElEhrMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RecNo)
                .HasMaxLength(20);

            this.Property(t => t.XMLFile)
                .IsRequired()
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
            this.ToTable("ElEhr");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecNo).HasColumnName("RecNo");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.ModifyOperTime).HasColumnName("ModifyOperTime");
            this.Property(t => t.ModifyOperID).HasColumnName("ModifyOperID");
            this.Property(t => t.PatMenuId).HasColumnName("PatMenuId");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.XMLFile).HasColumnName("XMLFile");
            this.Property(t => t.IsAuth).HasColumnName("IsAuth");
            this.Property(t => t.AuthOperTime).HasColumnName("AuthOperTime");
            this.Property(t => t.AuthOperId).HasColumnName("AuthOperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.XMLContent).HasColumnName("XMLContent");
            this.Property(t => t.IsRealease).HasColumnName("IsRealease");
            this.Property(t => t.RealeaseTime).HasColumnName("RealeaseTime");
            this.Property(t => t.RealeaseOperId).HasColumnName("RealeaseOperId");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.PrintTime).HasColumnName("PrintTime");
            this.Property(t => t.PrintOperId).HasColumnName("PrintOperId");
            this.Property(t => t.IsClosed).HasColumnName("IsClosed");
            this.Property(t => t.ClosedTime).HasColumnName("ClosedTime");
            this.Property(t => t.ClosedOperId).HasColumnName("ClosedOperId");
            this.Property(t => t.IsCheck).HasColumnName("IsCheck");

            // Relationships
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.ElEhrs)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.ElEhrs)
                .HasForeignKey(d => d.OperID);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.ElEhrs1)
                .HasForeignKey(d => d.AuthOperId);
            this.HasRequired(t => t.GblPatientMenu)
                .WithMany(t => t.ElEhrs)
                .HasForeignKey(d => d.PatMenuId);

        }
    }
}
