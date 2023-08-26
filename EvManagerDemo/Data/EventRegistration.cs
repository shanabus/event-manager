using Microsoft.EntityFrameworkCore;

namespace EvManagerDemo.Data
{
    [EntityTypeConfiguration(typeof(EventRegistrationConfiguration))]
    public class EventRegistration
    {
        public EventRegistration()
        {
            Treatments = new List<Treatment>();
            Presenters = new List<Presenter>();
        }

        public int EventRegistrationId { get; set; }

        public Event? Event { get; set; }

        public string? Company { get; set; }

        public string? Location {  get; set; }

        public int? Admissions {  get; set; }

        public string? Website { get; set; }

        public string? PatientGender { get; set; }

        public bool InHouseDetox { get; set; }
        
        public bool TobaccoFree { get; set; }
        
        public bool MedicationAssistedTherapy { get; set; }
        
        public bool PatientsCaseManaged { get; set; }

        public bool AcceptInsurance { get; set; }
        
        public bool FinancialAid { get; set; }

        public string? Membership { get; set; }
        
        public string? Accredidation { get; set; }

        public string? ClientAgeRange { get; set; }

        public int NumberOfBeds { get; set; }

        public int YearsOpen { get; set; }

        public ICollection<Treatment> Treatments { get; set; }

        public ICollection<Presenter> Presenters { get; set; }

        public string? UniqueFeatures1 { get; set; }
        
        public string? UniqueFeatures2 { get; set; }

        public string? UniqueFeatures3 { get; set; }

        public string? AdditionalNotes { get; set; }
    }
}