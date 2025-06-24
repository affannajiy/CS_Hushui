public class Paragraph
{
    public string Text { get; set; }

    //Constructor
    public Paragraph(string text)
    {
        Text = text;
    }
}

public class Document
{
    public List<Paragraph> paragraphs = new List<Paragraph>();
    
    //Method to Add Paragraph
    public void AddParagraph(Paragraph paragraph)
    {
        paragraphs.Add(paragraph);
    }

    //Method to Add Line
    public void readLine(string text)
    {
        AddParagraph(new Paragraph(text));
    }

    //Method to Display
    public void Display()
    {
        foreach (var paragraph in paragraphs)
        {
            Console.WriteLine(paragraph.Text);
        }
    }
}