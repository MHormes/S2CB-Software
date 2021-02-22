using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1InheritanceTransportation
{
    public class TransportationManager
    {
        List<Transportation> transportations;

        public TransportationManager()
        {
            transportations = new List<Transportation>();
        }

        public void AddTransportation(Transportation t)
        {
            transportations.Add(t);
        }


        public List<Transportation> GetTransportations()
        {
            return transportations;
        }
    }
}
