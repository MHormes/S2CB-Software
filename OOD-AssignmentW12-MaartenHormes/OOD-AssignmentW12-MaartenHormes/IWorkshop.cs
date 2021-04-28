﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public interface IWorkshop
    {
        string Name
        {
            get; set;
        }

        string Description
        {
            get; set;
        }

        int MaxCapacity
        {
            get; set;
        }

        bool Started
        {
            get; set;
        }
    }
}
