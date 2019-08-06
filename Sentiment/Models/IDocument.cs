namespace Sentiment.Models
{
    public interface IDocument
    {
        string Id { get; set; }
        string Language { get; set; }
        string Text { get; set; }
    }
}