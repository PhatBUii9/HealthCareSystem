using Classes;

public class Doctor : User
{
    public static List<Doctor> _allDoctors = new List<Doctor>();
    private static int s_doctorID = 1;
    private static string s_role = "doctor";
    public string Specialty { set; get; }
    public string DoctorID { get; }
    
    public Doctor(string firstName, string lastName, string specialty="") : base(firstName, lastName)
    {
        this.Specialty = specialty;
        DoctorID = $"DOC{s_doctorID}";
        s_doctorID++;
    }


    public override void AddUser()
    {
        Doctor user = new Doctor(FirstName, LastName, Specialty);
        _allDoctors.Add(user);
    }

    public override void RemoveUser()
    {
        _allDoctors.RemoveAll(doctor => doctor.DoctorID == this.DoctorID);
    }

    public override void DisplayInformation()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Doctor ID: {DoctorID}");
        Console.WriteLine($"Specialty: {Specialty}.");
    }

    public static string DisplayDoctorList()
    {
        int counter = 1;
        var report = new System.Text.StringBuilder();

        report.AppendLine("\tName\t\tDoctor ID\tSpecialty");
        foreach (Doctor doctor in _allDoctors)
        {
            report.AppendLine($"{counter}\t{doctor.FirstName} {doctor.LastName}\t{doctor.DoctorID}\t\t{doctor.Specialty}");
            counter ++;
        }

        return report.ToString();
    }
}