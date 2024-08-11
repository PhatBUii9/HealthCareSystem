using Classes;

public class UserFactory : IUserFactory
{

    public User Create(UserRole userRole, string firstName, string lastName)
    {
        switch (userRole)
        {
            case UserRole.Patient:
                return new Patient(firstName, lastName);
            case UserRole.Doctor:
                return new Doctor(firstName, lastName);
            case UserRole.Nurse:
                return new Nurse(firstName, lastName);
            default:
                throw new ArgumentException("Invalid user role");
        }
    }
}