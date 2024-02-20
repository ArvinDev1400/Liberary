namespace Domain.Entities;

public class LoanedBook
{
    public long Id { get; set; }
    public DateTime LendingDateTime { get; set; } = DateTime.Now;
    public DateTime? ReturnDateTime { get; set; }
    public int DaysReturn { get; set; }


    public Book Book { get; set; }
    public int BookId { get; set; }

    public Member Member { get; set; }
    public int MemberId { get; set; }
}