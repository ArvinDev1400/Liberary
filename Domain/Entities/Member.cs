namespace Domain.Entities;

public class Member
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string Eamil { get; set; }

    public ICollection<LoanedBook> LoanedBooks { get; set; }
}