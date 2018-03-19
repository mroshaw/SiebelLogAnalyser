using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiebelLogAnalyser
{
    class SiebelMessage
    {
        public String ComponentName { get; set; }
        public String EventName { get; set; }
        public DateTime MessageDate { get; set; }
        public String MessageCode { get; set; }
        public String MessageText { get; set; }
        public String FileName { get; set; }
        public int LineNumber { get; set; }
        public int ErrorLevel { get; set; }

        public SiebelMessage(String componentName, String eventName, int errorLevel, DateTime messageDate, String messageCode, String messageText, String fileName, int lineNumber)
        {
            ComponentName = componentName;
            EventName = eventName;
            ErrorLevel = errorLevel;
            MessageDate = messageDate;
            MessageCode = messageCode;
            MessageText = messageText;
            FileName = fileName;
            LineNumber = lineNumber;
        }
    }
}
