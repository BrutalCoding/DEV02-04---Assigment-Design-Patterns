using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignmentOP4New.Interfaces;

namespace assignmentOP4New.Components
{
    class Some<T> : IOption<T>
    {
        private T value;

        public Some(T v)
        {
            this.value = v;
        }
        public U Visit<U>(Func<U> onNone, Func<T, U> onSome)
        {
            return onSome(value);
        }

        public bool IsNone()
        {
            return false;
        }

        public bool IsSome()
        {
            return true;
        }
    }
}
