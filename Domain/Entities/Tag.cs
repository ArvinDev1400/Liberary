﻿namespace Domain.Entities;

public class Tag
{
    public int Id { get; set; }
    public string Title { get; set; }
    public ICollection<Book> Books { get; set; }
}