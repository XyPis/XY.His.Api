using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class vw_inhosinfoxxMap : EntityTypeConfiguration<vw_inhosinfoxx>
    {
        public vw_inhosinfoxxMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.patid, t.inpatno, t.name, t.sex, t.ntime, t.intime, t.lsinstatus, t.opertime, t.operid, t.company, t.idcardno, t.infoLinkmanName, t.PhoneHome, t.MedicareNo, t.PatLinkmanName, t.pattypeid, t.pattypename, t.arrearfei, t.discdiag, t.discin, t.tallytypename, t.tallygroupid, t.tallygroupname, t.locid, t.locname });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.patid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.inpatno)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Age)
                .HasMaxLength(100);

            this.Property(t => t.ntime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.lsinstatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.operid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.idcardno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TipsNurse)
                .HasMaxLength(500);

            this.Property(t => t.infoLinkmanName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Phone)
                .HasMaxLength(15);

            this.Property(t => t.PhoneHome)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.MedicareNo)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.PatLinkmanName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pattypeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pattypename)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.arrearfei)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.discdiag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.discin)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pattypef3)
                .HasMaxLength(100);

            this.Property(t => t.tallytypename)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.tallygroupid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tallygroupname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.locid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.locname)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.areaname)
                .HasMaxLength(50);

            this.Property(t => t.areapolicestationname)
                .HasMaxLength(50);

            this.Property(t => t.areaCommitteename)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vw_inhosinfoxx");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.patid).HasColumnName("patid");
            this.Property(t => t.inpatno).HasColumnName("inpatno");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.sex).HasColumnName("sex");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.ntime).HasColumnName("ntime");
            this.Property(t => t.intime).HasColumnName("intime");
            this.Property(t => t.outtime).HasColumnName("outtime");
            this.Property(t => t.docmz).HasColumnName("docmz");
            this.Property(t => t.doctorid).HasColumnName("doctorid");
            this.Property(t => t.locationid).HasColumnName("locationid");
            this.Property(t => t.bedid).HasColumnName("bedid");
            this.Property(t => t.lsinstatus).HasColumnName("lsinstatus");
            this.Property(t => t.opertime).HasColumnName("opertime");
            this.Property(t => t.operid).HasColumnName("operid");
            this.Property(t => t.motherhospid).HasColumnName("motherhospid");
            this.Property(t => t.mzregid).HasColumnName("mzregid");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.idcardno).HasColumnName("idcardno");
            this.Property(t => t.TipsNurse).HasColumnName("TipsNurse");
            this.Property(t => t.infoLinkmanName).HasColumnName("infoLinkmanName");
            this.Property(t => t.birthdate).HasColumnName("birthdate");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.PhoneHome).HasColumnName("PhoneHome");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
            this.Property(t => t.PatLinkmanName).HasColumnName("PatLinkmanName");
            this.Property(t => t.pattypeid).HasColumnName("pattypeid");
            this.Property(t => t.pattypename).HasColumnName("pattypename");
            this.Property(t => t.arrearfei).HasColumnName("arrearfei");
            this.Property(t => t.discdiag).HasColumnName("discdiag");
            this.Property(t => t.discin).HasColumnName("discin");
            this.Property(t => t.pattypef3).HasColumnName("pattypef3");
            this.Property(t => t.tallytypename).HasColumnName("tallytypename");
            this.Property(t => t.tallygroupid).HasColumnName("tallygroupid");
            this.Property(t => t.tallygroupname).HasColumnName("tallygroupname");
            this.Property(t => t.locid).HasColumnName("locid");
            this.Property(t => t.locname).HasColumnName("locname");
            this.Property(t => t.areaid).HasColumnName("areaid");
            this.Property(t => t.areaname).HasColumnName("areaname");
            this.Property(t => t.areapolicestationid).HasColumnName("areapolicestationid");
            this.Property(t => t.areapolicestationname).HasColumnName("areapolicestationname");
            this.Property(t => t.areaCommitteename).HasColumnName("areaCommitteename");
        }
    }
}
