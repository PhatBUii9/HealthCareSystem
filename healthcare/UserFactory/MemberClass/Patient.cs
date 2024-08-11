using Classes;

public class Patient : User
{
    private static List<Patient> _allPatients = new List<Patient>();
    private static int s_patientID = 1;
    private static string s_role = "patient";

    public string MedicalHistory { set; get; }
    public string PatientID { get; }
    public Patient(string firstName, string lastName, string medicalHistory = "") : base(firstName, lastName)
    {
        this.MedicalHistory = medicalHistory;
        PatientID = $"PAT{s_patientID}";
        s_patientID++;
        _allPatients.Add(this);
    }

    public void updateUser(string newFirstName, string newLastName, string newMedicalHistory)
    {
        FirstName = newFirstName;
        LastName = newLastName;
        MedicalHistory = newMedicalHistory;
    }

    public override void RemoveUser()
    {
        _allPatients.RemoveAll(patient => patient.PatientID == this.PatientID);
    }

    public override void DisplayInformation()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Patient ID: {PatientID}");

        if (MedicalHistory == "")
            Console.WriteLine("Medical History: none.");
        else
            Console.WriteLine($"Medical History: {MedicalHistory}.");
    }

    public static string DisplayPatientList()
    {
        var report = new System.Text.StringBuilder();

        report.AppendLine("Name\t\tPatient ID");
        foreach (Patient patient in _allPatients)
        {
            report.AppendLine($"{patient.FirstName} {patient.LastName}\t{patient.PatientID}");
        }

        return report.ToString();
    }
}