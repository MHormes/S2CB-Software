using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardAssignment
{
    public class MessageBoard
    {
        private string name;

        public string Name
        {
            get; set;
        }

        public MessageBoard(string name)
        {
            Name = name;
        }

        public Channel GetAvailableChannel()
        {
            return null;
        }

        public void BanParentFromBoard()
        {

        }
    }
}
