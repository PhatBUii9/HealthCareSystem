using Classes;

public class AppointmentFactory : IAppointmentFactory
{

    public Appointment Create(Patient patient, Doctor doctor, DateTime dateTime)
    {
        return new Appointment(patient, doctor, dateTime);
    }
}