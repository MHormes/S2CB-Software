using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardAssignment
{
    public class MessageManager
    {
        public void PostMessage(string text, string author, Channel channel)
        {
            channel.AddMessage(new Message(text, author));
        }

        public List<Message> GetMessages(Channel channel)
        {
            return channel.GetMessages();
        } 

        public Message[] GetMessages(DateTime sinceTimeStamp, int channel)
        {
            return null;
        }
    }
}