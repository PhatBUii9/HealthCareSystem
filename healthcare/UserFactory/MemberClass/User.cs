namespace Classes;

public abstract class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    //public string role { get; set; }

    public User(string firstName, string lastName) {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
    
    public virtual void updateUser(){}
    public virtual void AddUser(){}
    
    public abstract void RemoveUser();
    public abstract void DisplayInformation();
}