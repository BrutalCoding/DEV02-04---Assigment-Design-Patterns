﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4
{
    class Some<T> : Option<T>
    {
        T v;

        public bool IsNone()
        {
            throw new NotImplementedException();
        }

        public bool IsSome()
        {
            throw new NotImplementedException();
        }

        public U Visit<U>(Func<U> OnNone, Func<T, U> OnSome)
        {
            throw new NotImplementedException();
        }
    }
}