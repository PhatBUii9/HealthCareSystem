using Classes;

public interface IUserFactory
{
    User Create(UserRole userRole, string firstName, string lastName);
}