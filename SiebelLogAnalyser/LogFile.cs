using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SiebelLogAnalyser
{
    class LogFile
    {
        public String FilePath { get; set; }
        // public SiebelMessages SiebelMessages {get; set;}
        public List<SiebelMessage> Messages { get; set; }

        public String LogFileText;
        public String[] LogFileTextLines;
        public List<LogLine> LogFileListOfLines;
        public LogFile(String filePath)
        {
            FilePath = filePath;
            Messages = new List<SiebelMessage>();
            LogFileListOfLines = new List<LogLine>();
        }

        public Boolean Analyse()
        {
            // Check to see if the file exists
            if (!File.Exists(FilePath))
            {
                throw (new FileNotFoundException());
            }
            StreamReader streamReader = null;
            try
            {
                // Open the file for reading
                streamReader = new StreamReader(FilePath, true);
            }
            catch(Exception)
            {
                MessageBox.Show("An error occurred opening the log file. It may be open in another application (e.g. the Siebel Client)");
            }
            if (streamReader == null) return false;
            // Use StringBuilder as this could be a massive Replace process, depending on the file size
            StringBuilder stringBuilder = new StringBuilder(streamReader.ReadToEnd());
 
            // Siebel uses a mixture of UNIX and Windows line terminators which confuse the 'Lines' control property
            // Strip these out and replace with Environment specific NewLine
            stringBuilder.Replace("\r", "").Replace("\n", Environment.NewLine);
            // stringBuilder.Replace("\r\n", Environment.NewLine);
            LogFileText = stringBuilder.ToString();

            int lineNum = 1;
            LogFileTextLines = LogFileText.Split(new String[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (String line in LogFileTextLines)
            {
                LogFileListOfLines.Add(new LogLine(lineNum, line));
                AnalyseLine(line, lineNum);
                lineNum++;
            }
            return true;
        }

        private void AnalyseLine(String line, int lineNum)
        {
            int messageCodeIndex = line.IndexOf("SBL-", StringComparison.Ordinal);

            // Is there a Siebel Error Code in this line?
            if (messageCodeIndex > 0)
            {
                String[] lineProperties = line.Split('\t');
                int lineLength = line.Length;
                if (lineProperties.Count() == 6)
                {
                    // Get basic properties that reside in the same location in each file
                    String msgComponent = lineProperties[0];
                    String msgEvent = lineProperties[1];
                    String msgLevel = lineProperties[2];
                    String msgDateTime = lineProperties[4];
                    String msgContents = lineProperties[5];

                    int endOfMessageIndex = line.IndexOf(':', messageCodeIndex);
                    if (endOfMessageIndex == -1) endOfMessageIndex = lineLength - 2;
                    if (endOfMessageIndex != -1)
                    {
                        // String msgCode = line.Substring(messageCodeIndex, endOfMessageIndex - messageCodeIndex);
                        String msgCode = line.Substring(messageCodeIndex, 13);
                        String msgText = line.Substring(endOfMessageIndex + 2);
                        SiebelMessage msg = new SiebelMessage(msgComponent, msgEvent, Convert.ToInt16(msgLevel), DateTime.Parse(msgDateTime), msgCode, msgText, Path.GetFileName(FilePath), lineNum);
                        Messages.Add(msg);
                    }
                }
            }
        }
    }

    class LogLine
    {
        public int LineNumber;
        public String Line;

        public LogLine(int lineNumber, String line)
        {
            LineNumber = lineNumber;
            Line = line;
        }
    }


}
