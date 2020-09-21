using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sentiment.Clients
{
    public class LineWriter : ILineWriter {

        private readonly IGhostWriter _ghostWriter;

        public LineWriter(IGhostWriter ghostWriter)
    {
            _ghostWriter = ghostWriter; 
    }
    
        public void WriteMessage(string message)
        {
            Console.WriteLine($"LineWriter.WriteMessage Message: {message}");
        }

        public int DoSomeMath(int int1, int int2)
        {
            return int1 + int2;
        }

        public string GetGhost()
        {
            return _ghostWriter.GetGhost();
        }
    }
}
