using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS.Common.Exception
{
    public class ItemNotFoundException:System.Exception
    {
        public ItemNotFoundException(string message) : base(message)
        { }
    }
}
