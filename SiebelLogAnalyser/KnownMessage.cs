using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiebelLogAnalyser
{
    public class KnownMessage
    {
        public String MessageCode { get; set; }
        public String MessageDescription { get; set; }
        public String MessageSolution { get; set; }

        public KnownMessage (String messageCode, String messageDescription, String messageSolution)
        {
            MessageCode = messageCode;
            MessageDescription = messageDescription;
            MessageSolution = messageSolution;
        }

        public KnownMessage()
        {
            MessageCode = "";
            MessageDescription = "";
            MessageSolution = "";
        }
    }
}
