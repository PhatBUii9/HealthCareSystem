public class Appointment
{
    private static List<Appointment> _allAppointments = new List<Appointment>();
    public Patient Patient { get; private set; }
    public Doctor Doctor { get; private set; }
    public DateTime Datetime { get; private set; }

    public Appointment (Patient patient, Doctor doctor, DateTime datetime)
    {   
        this.Patient = patient;
        this.Doctor = doctor;
        this.Datetime = datetime;
        _allAppointments.Add(this);
        Console.WriteLine($"Appointment created for {patient.FirstName} {patient.LastName} with Dr. {doctor.FirstName} {doctor.LastName} on {datetime}");
    }

    public void updateAppointment(Patient newPatient, Doctor newDoctor, DateTime newDateTime) 
    {
        Patient = newPatient;
        Doctor = newDoctor;
        Datetime = newDateTime;
    }

    public void removeAppointment() 
    {
        _allAppointments.RemoveAll(
            appointment => appointment.Datetime == this.Datetime
         && appointment.Patient == this.Patient
         && appointment.Doctor == this.Doctor
        );
    }

    public static string DisplayAppointments(Patient patient)
    {
        var report = new System.Text.StringBuilder();

        report.AppendLine("Patient\t\tDoctor\t\tDate and Time");
        foreach (Appointment appointment in _allAppointments)
        {
            if (appointment.Patient == patient)
            {
                Doctor doctor = appointment.Doctor;
                report.AppendLine($"{patient.FirstName} {patient.LastName}\t{doctor.FirstName} {doctor.LastName}\t{appointment.Datetime}");
            }
        }

        return report.ToString();
    }

    public static string DisplayAppointments(Doctor doctor)
    {
        var report = new System.Text.StringBuilder();

        report.AppendLine("Patient\t\tDoctor\t\tDate and Time");
        foreach (Appointment appointment in _allAppointments)
        {
            if (appointment.Doctor == doctor)
            {
                Patient patient = appointment.Patient;
                report.AppendLine($"{patient.FirstName} {patient.LastName}\t{doctor.FirstName} {doctor.LastName}\t{appointment.Datetime}");
            }
        }

        return report.ToString();
    }



}