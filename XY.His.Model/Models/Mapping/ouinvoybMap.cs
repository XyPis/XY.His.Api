using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ouinvoybMap : EntityTypeConfiguration<ouinvoyb>
    {
        public ouinvoybMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.MzRegID, t.f5, t.f6, t.f7, t.f8 });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.f1)
                .HasMaxLength(50);

            this.Property(t => t.f2)
                .HasMaxLength(50);

            this.Property(t => t.f3)
                .HasMaxLength(50);

            this.Property(t => t.f4)
                .HasMaxLength(50);

            this.Property(t => t.accountattribute)
                .HasMaxLength(50);

            this.Property(t => t.medicalno)
                .HasMaxLength(50);

            this.Property(t => t.MzRegID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.f5)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.f6)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.f7)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.f8)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ouinvoyb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.invoid).HasColumnName("invoid");
            this.Property(t => t.factyp).HasColumnName("factyp");
            this.Property(t => t.factjz).HasColumnName("factjz");
            this.Property(t => t.allfactyp).HasColumnName("allfactyp");
            this.Property(t => t.allfactjz).HasColumnName("allfactjz");
            this.Property(t => t.otherfact).HasColumnName("otherfact");
            this.Property(t => t.ybdisc).HasColumnName("ybdisc");
            this.Property(t => t.insurance).HasColumnName("insurance");
            this.Property(t => t.underline).HasColumnName("underline");
            this.Property(t => t.insuranceb1).HasColumnName("insuranceb1");
            this.Property(t => t.insuranceb2).HasColumnName("insuranceb2");
            this.Property(t => t.insuranceb3).HasColumnName("insuranceb3");
            this.Property(t => t.payself).HasColumnName("payself");
            this.Property(t => t.selfpaydisc).HasColumnName("selfpaydisc");
            this.Property(t => t.selfpayb1).HasColumnName("selfpayb1");
            this.Property(t => t.selfpayb2).HasColumnName("selfpayb2");
            this.Property(t => t.selfpayb3).HasColumnName("selfpayb3");
            this.Property(t => t.outtopselffee).HasColumnName("outtopselffee");
            this.Property(t => t.selffee).HasColumnName("selffee");
            this.Property(t => t.f1).HasColumnName("f1");
            this.Property(t => t.f2).HasColumnName("f2");
            this.Property(t => t.f3).HasColumnName("f3");
            this.Property(t => t.f4).HasColumnName("f4");
            this.Property(t => t.accountattribute).HasColumnName("accountattribute");
            this.Property(t => t.bchzylbxamount).HasColumnName("bchzylbxamount");
            this.Property(t => t.bcproportion).HasColumnName("bcproportion");
            this.Property(t => t.fdamount).HasColumnName("fdamount");
            this.Property(t => t.kbca1).HasColumnName("kbca1");
            this.Property(t => t.kbca12).HasColumnName("kbca12");
            this.Property(t => t.kbca13).HasColumnName("kbca13");
            this.Property(t => t.kbca16).HasColumnName("kbca16");
            this.Property(t => t.kbca17).HasColumnName("kbca17");
            this.Property(t => t.kbca18).HasColumnName("kbca18");
            this.Property(t => t.kbca19).HasColumnName("kbca19");
            this.Property(t => t.kbca2).HasColumnName("kbca2");
            this.Property(t => t.kbca20).HasColumnName("kbca20");
            this.Property(t => t.kbca3).HasColumnName("kbca3");
            this.Property(t => t.kbca4).HasColumnName("kbca4");
            this.Property(t => t.kbca5).HasColumnName("kbca5");
            this.Property(t => t.kbca6).HasColumnName("kbca6");
            this.Property(t => t.kbcamount).HasColumnName("kbcamount");
            this.Property(t => t.medicalno).HasColumnName("medicalno");
            this.Property(t => t.ndybcamount).HasColumnName("ndybcamount");
            this.Property(t => t.originala1).HasColumnName("originala1");
            this.Property(t => t.originala12).HasColumnName("originala12");
            this.Property(t => t.originala13).HasColumnName("originala13");
            this.Property(t => t.originala16).HasColumnName("originala16");
            this.Property(t => t.originala17).HasColumnName("originala17");
            this.Property(t => t.originala18).HasColumnName("originala18");
            this.Property(t => t.originala19).HasColumnName("originala19");
            this.Property(t => t.originala2).HasColumnName("originala2");
            this.Property(t => t.originala20).HasColumnName("originala20");
            this.Property(t => t.originala3).HasColumnName("originala3");
            this.Property(t => t.originala4).HasColumnName("originala4");
            this.Property(t => t.originala5).HasColumnName("originala5");
            this.Property(t => t.originala6).HasColumnName("originala6");
            this.Property(t => t.originalamount).HasColumnName("originalamount");
            this.Property(t => t.sjbca1).HasColumnName("sjbca1");
            this.Property(t => t.sjbca12).HasColumnName("sjbca12");
            this.Property(t => t.sjbca13).HasColumnName("sjbca13");
            this.Property(t => t.sjbca16).HasColumnName("sjbca16");
            this.Property(t => t.sjbca17).HasColumnName("sjbca17");
            this.Property(t => t.sjbca18).HasColumnName("sjbca18");
            this.Property(t => t.sjbca19).HasColumnName("sjbca19");
            this.Property(t => t.sjbca2).HasColumnName("sjbca2");
            this.Property(t => t.sjbca20).HasColumnName("sjbca20");
            this.Property(t => t.sjbca3).HasColumnName("sjbca3");
            this.Property(t => t.sjbca4).HasColumnName("sjbca4");
            this.Property(t => t.sjbca5).HasColumnName("sjbca5");
            this.Property(t => t.sjbca6).HasColumnName("sjbca6");
            this.Property(t => t.tgproportion).HasColumnName("tgproportion");
            this.Property(t => t.wbhproportion).HasColumnName("wbhproportion");
            this.Property(t => t.zyyproportion).HasColumnName("zyyproportion");
            this.Property(t => t.zzproportion).HasColumnName("zzproportion");
            this.Property(t => t.MzRegID).HasColumnName("MzRegID");
            this.Property(t => t.f5).HasColumnName("f5");
            this.Property(t => t.f6).HasColumnName("f6");
            this.Property(t => t.f7).HasColumnName("f7");
            this.Property(t => t.f8).HasColumnName("f8");
        }
    }
}
