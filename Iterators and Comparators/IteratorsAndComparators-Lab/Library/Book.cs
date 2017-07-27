using System.Collections.Generic;

public class Book
{
    public Book(string title, int age, params string[] authors)
    {
        this.Title = title;
        this.Age = age;
        this.Authors = authors;
    }

    public string  Title { get; private set; }
    public int  Age { get; private set; }

    public IReadOnlyList<string> Authors { get; private set; }
}

