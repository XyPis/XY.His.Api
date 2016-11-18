using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OpsNurseMap : EntityTypeConfiguration<OpsNurse>
    {
        public OpsNurseMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Hand_Washing__Nurse)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Replace_Hand__Nurse)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Visiting_Nurse)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Replace_Visiting_Nurse)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Surgery_Position)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Local_Anesthesia_Is_Drug_Use)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Constrained)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.A_Hand)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Negative_Plate)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Infusion_Parts)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Phoebe_Time3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Picasso__Skin_Cond)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.The_catheter)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Total_Intake)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Always_Ggives_Quantity)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Parts)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OpsNurse");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ApplyId).HasColumnName("ApplyId");
            this.Property(t => t.Hand_Washing__Nurse).HasColumnName("Hand Washing  Nurse");
            this.Property(t => t.Replace_Hand__Nurse).HasColumnName("Replace Hand  Nurse");
            this.Property(t => t.Take_Time).HasColumnName("Take Time");
            this.Property(t => t.Visiting_Nurse).HasColumnName("Visiting Nurse");
            this.Property(t => t.Replace_Visiting_Nurse).HasColumnName("Replace Visiting Nurse");
            this.Property(t => t.Take_Time2).HasColumnName("Take Time2");
            this.Property(t => t.Surgery_Position).HasColumnName("Surgery Position");
            this.Property(t => t.Local_Anesthesia_Is_Drug_Use).HasColumnName("Local Anesthesia Is Drug Use");
            this.Property(t => t.Constrained).HasColumnName("Constrained");
            this.Property(t => t.A_Hand).HasColumnName("A Hand");
            this.Property(t => t.Air_Time).HasColumnName("Air Time");
            this.Property(t => t.Phoebe_Time).HasColumnName("Phoebe Time");
            this.Property(t => t.Negative_Plate).HasColumnName("Negative Plate");
            this.Property(t => t.Air_Time2).HasColumnName("Air Time2");
            this.Property(t => t.Phoebe_Time2).HasColumnName("Phoebe Time2");
            this.Property(t => t.Infusion_Parts).HasColumnName("Infusion Parts");
            this.Property(t => t.Air_time3).HasColumnName("Air time3");
            this.Property(t => t.Phoebe_Time3).HasColumnName("Phoebe Time3");
            this.Property(t => t.Picasso__Skin_Cond).HasColumnName("Picasso  Skin Cond");
            this.Property(t => t.Catheterization_Operating_Room).HasColumnName("Catheterization Operating Room");
            this.Property(t => t.The_catheter).HasColumnName("The catheter");
            this.Property(t => t.Electrotome).HasColumnName("Electrotome");
            this.Property(t => t.Argon_Knife).HasColumnName("Argon Knife");
            this.Property(t => t.Bipolar_Of_Electricity).HasColumnName("Bipolar Of Electricity");
            this.Property(t => t.Ultrasound_Scalpel).HasColumnName("Ultrasound Scalpel");
            this.Property(t => t.IsSend_Frozen_Section).HasColumnName("IsSend Frozen Section");
            this.Property(t => t.IsFor_Pathologic_Specimens).HasColumnName("IsFor Pathologic Specimens");
            this.Property(t => t.IsSend_Bacteria_Cultivation).HasColumnName("IsSend Bacteria Cultivation");
            this.Property(t => t.IsAseptic_Package_Passed__Examination).HasColumnName("IsAseptic Package Passed  Examination");
            this.Property(t => t.IsSurgical_Items_Inventory).HasColumnName("IsSurgical Items Inventory");
            this.Property(t => t.Total_Intake).HasColumnName("Total Intake");
            this.Property(t => t.Always_Ggives_Quantity).HasColumnName("Always Ggives Quantity");
            this.Property(t => t.Implant).HasColumnName("Implant");
            this.Property(t => t.Parts).HasColumnName("Parts");
        }
    }
}
