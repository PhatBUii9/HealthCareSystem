public class MedicalRecord 
{
    private static List<MedicalRecord> _allMedicalRecords = new List<MedicalRecord>();
    private static int s_recordID = 1;
    public Patient Patient { get; private set; }
    public Doctor Doctor { get; private set; }
    public string Diagnosis { get;  set; }
    public string RecordID { get; }
    public string Treatment { get; set;}

    public MedicalRecord (Patient patient, Doctor doctor, string diagnosis, string treament)
    {   
        this.Patient = patient;
        this.Doctor = doctor;
        this.Diagnosis = diagnosis;
        this.Treatment = treament;
        RecordID = $"{patient.FirstName.Substring(0,5)}{s_recordID}";
        s_recordID++;
        _allMedicalRecords.Add(this);
    }

    public void updateMedicalRecord(string newDiagnosis, string newTreatment) 
    {
        Diagnosis = newDiagnosis;
        Treatment = newTreatment;
    }

    public void removeMedicalRecord() 
    {
        _allMedicalRecords.RemoveAll(record => record.RecordID == this.RecordID);
    }

     public static string DisplayMedicalRecords(Patient patient)
    {
        var report = new System.Text.StringBuilder();

        report.AppendLine("Patient\t\tDoctor\t\tMedical Record ID\t\tDiagnosis\t\tTreatment");
        foreach (MedicalRecord record in _allMedicalRecords)
        {
            if (record.Patient == patient)
            {
                Doctor doctor = record.Doctor;
                report.AppendLine($"{patient.FirstName} {patient.LastName}\t{doctor.FirstName} {doctor.LastName}\t{record.Diagnosis}\t{record.Treatment}");
            }
        }

        return report.ToString();
    }

}