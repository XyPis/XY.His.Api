using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OpsPostTreatMap : EntityTypeConfiguration<OpsPostTreat>
    {
        public OpsPostTreatMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Drawing_tube_sites, t.Tracheal_intubation_time_out, t.The_patient_to, t.Time, t.Doctor_signature, t.Nurse_signature, t.In_the_recovery_room_anesthesia_patients_state, t.The_patient_is_in_the_recovery_room, t.The_patient_recovery_room, t.Anesthesia_recovery_after_scoring, t.Tracheal_intubation_time_out1, t.The_time_the_recovery_room, t.Transit_the_patient_s_condition_monitoring, t.Patient, t.Entourage, t.Is_happening, t.The_patient_sent_to_the_ward_both_sides_handover_project, t.The_recovery_room_sign_the_nurse_in_charge });

            // Properties
            this.Property(t => t.Drawing_tube_sites)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.The_patient_to)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Doctor_signature)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Nurse_signature)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.In_the_recovery_room_anesthesia_patients_state)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.The_patient_is_in_the_recovery_room)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.The_patient_recovery_room)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Anesthesia_recovery_after_scoring)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Transit_the_patient_s_condition_monitoring)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Patient)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Entourage)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Is_happening)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.The_patient_sent_to_the_ward_both_sides_handover_project)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.The_recovery_room_sign_the_nurse_in_charge)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OpsPostTreat");
            this.Property(t => t.Drawing_tube_sites).HasColumnName("Drawing tube sites");
            this.Property(t => t.Tracheal_intubation_time_out).HasColumnName("Tracheal intubation time out");
            this.Property(t => t.The_patient_to).HasColumnName("The patient to");
            this.Property(t => t.Time).HasColumnName("Time");
            this.Property(t => t.Doctor_signature).HasColumnName("Doctor signature");
            this.Property(t => t.Nurse_signature).HasColumnName("Nurse signature");
            this.Property(t => t.In_the_recovery_room_anesthesia_patients_state).HasColumnName("In the recovery room anesthesia patients state");
            this.Property(t => t.The_patient_is_in_the_recovery_room).HasColumnName("The patient is in the recovery room");
            this.Property(t => t.The_patient_recovery_room).HasColumnName("The patient recovery room");
            this.Property(t => t.Anesthesia_recovery_after_scoring).HasColumnName("Anesthesia recovery after scoring");
            this.Property(t => t.Tracheal_intubation_time_out1).HasColumnName("Tracheal intubation time out1");
            this.Property(t => t.The_time_the_recovery_room).HasColumnName("The time the recovery room");
            this.Property(t => t.Transit_the_patient_s_condition_monitoring).HasColumnName("Transit the patient's condition monitoring");
            this.Property(t => t.Patient).HasColumnName("Patient");
            this.Property(t => t.Entourage).HasColumnName("Entourage");
            this.Property(t => t.Is_happening).HasColumnName("Is happening");
            this.Property(t => t.The_patient_sent_to_the_ward_both_sides_handover_project).HasColumnName("The patient sent to the ward both sides handover project");
            this.Property(t => t.The_recovery_room_sign_the_nurse_in_charge).HasColumnName("The recovery room sign the nurse in charge");
        }
    }
}
