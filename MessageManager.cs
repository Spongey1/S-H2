namespace S_H2
{
    // Handles the sending of messages
    public class MessageManager
    {
        public void sendMessage(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            ConvertText Convertion = new ConvertText();
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = Convertion.ConvertBodyToText(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = Convertion.ConvertBodyToText(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
    }
}