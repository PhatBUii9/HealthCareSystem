using Classes;
public class Nurse : User
{
    public static List<Nurse> _allNurses = new List<Nurse>();
    private static int s_nurseID = 1;
    private static string s_role = "nurse";
    public string Department { set; get; }
    public string NurseID { get; }
    
    public Nurse(string firstName, string lastName, string department="") : base(firstName, lastName)
    {
        this.Department = department;
        NurseID = $"NUR{s_nurseID}";
        s_nurseID++;
    }


    public override void AddUser()
    {
        Nurse user = new Nurse(FirstName, LastName, Department);
        _allNurses.Add(user);
    }

    public override void RemoveUser()
    {
        _allNurses.RemoveAll(nurse => nurse.NurseID == this.NurseID);
    }

    public override void DisplayInformation()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Nurse ID: {NurseID}");
        Console.WriteLine($"Department: {Department}.");
    }

    public static string DisplayNurseList()
    {
        var report = new System.Text.StringBuilder();

        report.AppendLine("Name\t\tNurse ID\tSpecialty");
        foreach (Nurse nurse in _allNurses)
        {
            report.AppendLine($"{nurse.FirstName} {nurse.LastName}\t{nurse.NurseID}\t\t{nurse.Department}");
        }

        return report.ToString();
    }
}