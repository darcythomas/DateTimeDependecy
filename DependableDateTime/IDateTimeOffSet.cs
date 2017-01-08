using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependableDateTime
{
    public interface IDateTimeOffSet
    {
        DateTimeOffset Now { get; }

        DateTimeOffset UtcNow { get; }

    }
}
