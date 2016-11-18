using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InEMRMap : EntityTypeConfiguration<InEMR>
    {
        public InEMRMap()
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

            this.Property(t => t.F5)
                .HasMaxLength(100);

            this.Property(t => t.F6)
                .HasMaxLength(20);

            this.Property(t => t.F7)
                .HasMaxLength(20);

            this.Property(t => t.F8)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("InEMR");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecNo).HasColumnName("RecNo");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.ModifyOperTime).HasColumnName("ModifyOperTime");
            this.Property(t => t.ModifyOperID).HasColumnName("ModifyOperID");
            this.Property(t => t.CatalogId).HasColumnName("CatalogId");
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
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.OperTime2).HasColumnName("OperTime2");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.F8).HasColumnName("F8");

            // Relationships
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.InEMRs)
                .HasForeignKey(d => d.OperID);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.InEMRs1)
                .HasForeignKey(d => d.AuthOperId);
            this.HasRequired(t => t.GblEMRCatalog)
                .WithMany(t => t.InEMRs)
                .HasForeignKey(d => d.CatalogId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InEMRs)
                .HasForeignKey(d => d.HospId);

        }
    }
}
