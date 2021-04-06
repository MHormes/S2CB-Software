using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardAssignment
{
    public class Message
    {
        private DateTime timeStamp;
        private string text;
        private string author;

        public Message(string text, string author)
        {
            this.timeStamp = DateTime.Now;
            this.text = text;
            this.author = author;
        }

        public override string ToString()
        {
            return $"{this.text} by: {this.author}. On: {this.timeStamp}";
        }
    }
}
