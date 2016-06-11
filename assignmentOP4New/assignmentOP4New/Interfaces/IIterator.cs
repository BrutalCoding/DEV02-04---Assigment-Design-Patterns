﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4New.Interfaces
{
    interface IIterator<T>
    {
        IOption<T> GetNext();
        void Reset();
    }
}
