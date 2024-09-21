using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrleavemanagement.application.Execeptions
{
    public class badRequestException:ApplicationException
    {
        public badRequestException(string name,object key): base($"{name} ({key}) was not found")
        {
            
        }
    }
}
