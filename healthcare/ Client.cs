using Classes;

public class Client
{
    private User _user;
    private Appointment _appointment;
    public void CreateUser(UserRole role, string firstName, string lastName) 
    {
        IUserFactory userFactory = new UserFactory();
        _user = userFactory.Create(role, firstName, lastName);
    }

    public void CreateAppointment(Patient patient, Doctor doctor, DateTime dateTime)
    {
        IAppointmentFactory appointmentFactory = new AppointmentFactory();
        _appointment = appointmentFactory.Create(patient, doctor, dateTime);
    }

    public User GetUser()
    {
        return _user;
    }

    public Appointment GetAppointment()
    {
        return _appointment;
    }


}