using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public interface IPerson
    {
        string Name
        {
            get; set;
        }
        
        int PCN
        {
            get; set;
        }

        string Email
        {
            get; set;
        }

        List<Tuple<string, int>> SeatNumbers
        {
            get; set;
        }

        List<Tuple<string, string>> Password
        {
            get; set;
        }
    }
}
