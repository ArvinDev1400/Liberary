namespace Domain.Entities;
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }
    public string Publisher { get; set; }

    public Image Image { get; set; }

    public Category Category { get; set; }
    public int CategoryId { get; set; }


    public ICollection<Tag> Tags { get; set; }
    public ICollection<LoanedBook> LoanedBooks { get; set; }

    public Author Author { get; set; }
}