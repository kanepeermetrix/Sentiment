namespace Sentiment.Clients
{
    public interface ILineWriter
    {
        void WriteMessage(string message);
        int DoSomeMath(int int1, int int2);
        string GetGhost();
    }
}