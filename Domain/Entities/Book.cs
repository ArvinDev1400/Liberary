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

    //public Author Author { get; set; }
    //public int AuthorId { get; set; }
}

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public ICollection<Book> Books { get; set; }
}