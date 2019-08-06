using Microsoft.CodeAnalysis;

namespace Sentiment.Models
{
    public class Document : IDocument
    {
        public string Language { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
    }
}