using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class INADVICENURSEMap : EntityTypeConfiguration<INADVICENURSE>
    {
        public INADVICENURSEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(1000);

            this.Property(t => t.F1)
                .HasMaxLength(200);

            this.Property(t => t.F2)
                .HasMaxLength(200);

            this.Property(t => t.F3)
                .HasMaxLength(200);

            this.Property(t => t.F4)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("INADVICENURSE");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ADVICETIME).HasColumnName("ADVICETIME");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.HOSPID).HasColumnName("HOSPID");
            this.Property(t => t.GROUPNUM).HasColumnName("GROUPNUM");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.DOSAGE).HasColumnName("DOSAGE");
            this.Property(t => t.UNITTAKEID).HasColumnName("UNITTAKEID");
            this.Property(t => t.FREQUENCYID).HasColumnName("FREQUENCYID");
            this.Property(t => t.USAGEID).HasColumnName("USAGEID");
            this.Property(t => t.PRICEIN).HasColumnName("PRICEIN");
            this.Property(t => t.TOTALITY).HasColumnName("TOTALITY");
            this.Property(t => t.UNITINID).HasColumnName("UNITINID");
            this.Property(t => t.ISURGENT).HasColumnName("ISURGENT");
            this.Property(t => t.LSEXECLOC).HasColumnName("LSEXECLOC");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.ISAUTH).HasColumnName("ISAUTH");
            this.Property(t => t.AUTHOPERTIME).HasColumnName("AUTHOPERTIME");
            this.Property(t => t.AuthOperId).HasColumnName("AuthOperId");
            this.Property(t => t.ISLONG).HasColumnName("ISLONG");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CANCELOPERTIME).HasColumnName("CANCELOPERTIME");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsFrequency)
                .WithMany(t => t.INADVICENURSEs)
                .HasForeignKey(d => d.FREQUENCYID);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.INADVICENURSEs)
                .HasForeignKey(d => d.UNITINID);
            this.HasOptional(t => t.BsUnit1)
                .WithMany(t => t.INADVICENURSEs1)
                .HasForeignKey(d => d.UNITTAKEID);
            this.HasOptional(t => t.BsUsage)
                .WithMany(t => t.INADVICENURSEs)
                .HasForeignKey(d => d.USAGEID);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.INADVICENURSEs)
                .HasForeignKey(d => d.HOSPID);

        }
    }
}
