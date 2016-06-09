using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4
{
    class Some<T> : IOption<T>
    {
        T v;

        public bool IsNone()
        {
            return false;
        }

        public bool IsSome()
        {
            return true;
        }

        public U Visit<U>(Func<U> OnNone, Func<T, U> OnSome)
        {
            return OnSome(this.v);
        }
    }
}
