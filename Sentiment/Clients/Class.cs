using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sentiment.Clients
{
    public class GhostWriter : IGhostWriter
    {
        public string GetGhost()
        {
            return "I am a Ghost! WHoOOooOOOooooooOoo!";
        }
    }
}
