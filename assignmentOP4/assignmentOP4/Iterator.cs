﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4
{
    interface Iterator<T>
    {
        Option<T> GetNext();
        void Reset();
    }
}
