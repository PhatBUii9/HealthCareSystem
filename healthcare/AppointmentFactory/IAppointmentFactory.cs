using Classes;

public interface IAppointmentFactory
{
    Appointment Create(Patient patient, Doctor doctor, DateTime dateTime);
}