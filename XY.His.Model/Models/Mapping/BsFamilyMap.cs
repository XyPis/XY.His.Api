using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsFamilyMap : EntityTypeConfiguration<BsFamily>
    {
        public BsFamilyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.AddressHome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PhoneHome)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.PostCodeHome)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.AreaCodeHome)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.PyCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.InActiveReason)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsFamily");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.CommitteeId).HasColumnName("CommitteeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AddressHome).HasColumnName("AddressHome");
            this.Property(t => t.PhoneHome).HasColumnName("PhoneHome");
            this.Property(t => t.PostCodeHome).HasColumnName("PostCodeHome");
            this.Property(t => t.AreaCodeHome).HasColumnName("AreaCodeHome");
            this.Property(t => t.TotalPersons).HasColumnName("TotalPersons");
            this.Property(t => t.HousePersons).HasColumnName("HousePersons");
            this.Property(t => t.WorkingPersons).HasColumnName("WorkingPersons");
            this.Property(t => t.LsFamilyType).HasColumnName("LsFamilyType");
            this.Property(t => t.LsPeriod).HasColumnName("LsPeriod");
            this.Property(t => t.LsHouseType).HasColumnName("LsHouseType");
            this.Property(t => t.Acreage).HasColumnName("Acreage");
            this.Property(t => t.LsFuel).HasColumnName("LsFuel");
            this.Property(t => t.LsWarm).HasColumnName("LsWarm");
            this.Property(t => t.LsCold).HasColumnName("LsCold");
            this.Property(t => t.LsWater).HasColumnName("LsWater");
            this.Property(t => t.LsSaniFamily).HasColumnName("LsSaniFamily");
            this.Property(t => t.LsSaniPerson).HasColumnName("LsSaniPerson");
            this.Property(t => t.LsSaniHabit).HasColumnName("LsSaniHabit");
            this.Property(t => t.LsNeighbourhood).HasColumnName("LsNeighbourhood");
            this.Property(t => t.LsWC).HasColumnName("LsWC");
            this.Property(t => t.IsHealthBin).HasColumnName("IsHealthBin");
            this.Property(t => t.LsIncome).HasColumnName("LsIncome");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.InActiveReason).HasColumnName("InActiveReason");
            this.Property(t => t.InActiveTime).HasColumnName("InActiveTime");
            this.Property(t => t.InActiveOperID).HasColumnName("InActiveOperID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.RoadId).HasColumnName("RoadId");
            this.Property(t => t.IsSign).HasColumnName("IsSign");
            this.Property(t => t.IsCareMan).HasColumnName("IsCareMan");
            this.Property(t => t.SignDoctorId).HasColumnName("SignDoctorId");
            this.Property(t => t.SignGroupId).HasColumnName("SignGroupId");

            // Relationships
            this.HasRequired(t => t.BsAreaCommittee)
                .WithMany(t => t.BsFamilies)
                .HasForeignKey(d => d.CommitteeId);

        }
    }
}
