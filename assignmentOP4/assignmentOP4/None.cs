using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4
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

        public U Visit<U>(Func<U> OnNone, Func<T, U> OnSome)
        {
            return OnNone();
        }
    }
}
