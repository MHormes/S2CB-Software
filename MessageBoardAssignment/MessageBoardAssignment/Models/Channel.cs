using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardAssignment
{
    public class Channel
    {
        private int name;
        private List<Message> messages;

        public int Name
        {
            get; set;
        }
        public Channel(int name)
        {
            Name = name;
            messages = new List<Message>();
        }

        public List<Message> GetMessages()
        {
            return this.messages;
        }

        public void AddMessage(Message message)
        {
            messages.Add(message);
        }
    }
}
