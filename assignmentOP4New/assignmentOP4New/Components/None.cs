using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignmentOP4New.Interfaces;

namespace assignmentOP4New.Components
{
    class None<T> : IOption<T>
    {
        public bool IsNone()
        {
            return true;
        }

        public bool IsSome()
        {
            return false;
        }

        public U Visit<U>(Func<U> onNone, Func<T, U> onSome)
        {
            return onNone();
        }
    }
}
