using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4
{
    interface IOption<T>
    {
        U Visit<U>(Func<U> OnNone, Func<T, U> OnSome);
        bool IsSome();
        bool IsNone();
    }
}
