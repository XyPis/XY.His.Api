using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InYBBalanceMap : EntityTypeConfiguration<InYBBalance>
    {
        public InYBBalanceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.INVONO)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.TALLYNO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.REMARK)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CANCELMEMO)
                .HasMaxLength(1000);

            this.Property(t => t.F1)
                .HasMaxLength(200);

            this.Property(t => t.F2)
                .HasMaxLength(200);

            this.Property(t => t.F3)
                .HasMaxLength(200);

            this.Property(t => t.F4)
                .HasMaxLength(200);

            this.Property(t => t.NAME)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.INPATNO)
                .IsRequired()
                .HasMaxLength(26);

            // Table & Column Mappings
            this.ToTable("InYBBalance");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.INVONO).HasColumnName("INVONO");
            this.Property(t => t.LSPAYTYPE).HasColumnName("LSPAYTYPE");
            this.Property(t => t.HOSPID).HasColumnName("HOSPID");
            this.Property(t => t.PATTYPEID).HasColumnName("PATTYPEID");
            this.Property(t => t.FROMDATE).HasColumnName("FROMDATE");
            this.Property(t => t.TODATE).HasColumnName("TODATE");
            this.Property(t => t.CHARGEDAYS).HasColumnName("CHARGEDAYS");
            this.Property(t => t.BEPRICE).HasColumnName("BEPRICE");
            this.Property(t => t.TALLYNO).HasColumnName("TALLYNO");
            this.Property(t => t.FACTGET).HasColumnName("FACTGET");
            this.Property(t => t.INSURANCE).HasColumnName("INSURANCE");
            this.Property(t => t.PAYSELF).HasColumnName("PAYSELF");
            this.Property(t => t.AMOUNTPAY).HasColumnName("AMOUNTPAY");
            this.Property(t => t.DEPOSIT).HasColumnName("DEPOSIT");
            this.Property(t => t.COMPLEMENT).HasColumnName("COMPLEMENT");
            this.Property(t => t.ARREARAGE).HasColumnName("ARREARAGE");
            this.Property(t => t.ADDFEE).HasColumnName("ADDFEE");
            this.Property(t => t.REMARK).HasColumnName("REMARK");
            this.Property(t => t.OPERTIME).HasColumnName("OPERTIME");
            this.Property(t => t.OPERID).HasColumnName("OPERID");
            this.Property(t => t.ISCANCEL).HasColumnName("ISCANCEL");
            this.Property(t => t.CANCELOPERTIME).HasColumnName("CANCELOPERTIME");
            this.Property(t => t.CANCELOPERID).HasColumnName("CANCELOPERID");
            this.Property(t => t.CANCELMEMO).HasColumnName("CANCELMEMO");
            this.Property(t => t.INVOLASTID).HasColumnName("INVOLASTID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.HOSPITALID).HasColumnName("HOSPITALID");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.INPATNO).HasColumnName("INPATNO");
            this.Property(t => t.SUMFEE).HasColumnName("SUMFEE");
            this.Property(t => t.AMOUNTINSURANCE).HasColumnName("AMOUNTINSURANCE");
            this.Property(t => t.AMOUNTFACT).HasColumnName("AMOUNTFACT");
            this.Property(t => t.INTIME).HasColumnName("INTIME");
            this.Property(t => t.OUTTIME).HasColumnName("OUTTIME");
            this.Property(t => t.REPORTCONTENT).HasColumnName("REPORTCONTENT");
        }
    }
}
