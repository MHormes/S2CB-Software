using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardAssignment
{
    public class ChannelManager
    {
        private List<Channel> channelList = new List<Channel>();

        public ChannelManager()
        {
            channelList.Add(new Channel(1));
            channelList.Add(new Channel(2));
            channelList.Add(new Channel(3));
            channelList.Add(new Channel(4));
            channelList.Add(new Channel(5));
            channelList.Add(new Channel(6));
            channelList.Add(new Channel(7));
            channelList.Add(new Channel(8));
        }

        public List<Channel> GetChannels()
        {
            return this.channelList;
        }

        public Channel GetCurrentChannel(int currentChannel)
        {
            foreach(Channel c in channelList) 
            {
                if(c.Name == currentChannel)
                {
                    return c;
                }
            }

            return null;
        }
    }
}
