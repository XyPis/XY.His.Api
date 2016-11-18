using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwInAndOuInvoiceMap : EntityTypeConfiguration<VwInAndOuInvoice>
    {
        public VwInAndOuInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Hosp_NO, t.InvoTime, t.LocationName, t.Beprice, t.SpeciaIll, t.jbname });

            // Properties
            this.Property(t => t.ID_NO)
                .HasMaxLength(29);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hosp_NO)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.Invo_Num)
                .HasMaxLength(20);

            this.Property(t => t.CHINESE)
                .HasMaxLength(30);

            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Beprice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Operator)
                .HasMaxLength(10);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.SpeciaIll)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.jbname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.HospitalName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwInAndOuInvoice");
            this.Property(t => t.ID_NO).HasColumnName("ID_NO");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Hosp_NO).HasColumnName("Hosp_NO");
            this.Property(t => t.Invo_Num).HasColumnName("Invo_Num");
            this.Property(t => t.CHINESE).HasColumnName("CHINESE");
            this.Property(t => t.InvoTime).HasColumnName("InvoTime");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.Beprice).HasColumnName("Beprice");
            this.Property(t => t.SumTil).HasColumnName("SumTil");
            this.Property(t => t.Pay_Self).HasColumnName("Pay_Self");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.SpeciaIll).HasColumnName("SpeciaIll");
            this.Property(t => t.jbname).HasColumnName("jbname");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.HospitalName).HasColumnName("HospitalName");
        }
    }
}
