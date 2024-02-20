namespace Domain.Entities;

public class Image
{
    public int Id { get; set; }
    public string Src { get; set; }

    public Book Book { get; set; }
    public int BookId { get; set; }
}