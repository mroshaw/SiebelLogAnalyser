using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace SiebelLogAnalyser
{
    class KnownMessages
    {
        public static List<KnownMessage> ListOfKnownMessages;

        public void LoadMessages(String filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List <KnownMessage>));

            using (FileStream stream = File.OpenRead(filePath))
            {
                ListOfKnownMessages = (List<KnownMessage>)serializer.Deserialize(stream);
            }
        }

        public static KnownMessage LookupMessageCode(String messageCode)
        {
            KnownMessage knownMessage = ListOfKnownMessages.Find(message => message.MessageCode == messageCode);
            return knownMessage;
        }
    }
}
