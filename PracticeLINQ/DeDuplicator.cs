using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLINQ
{
    class DeDuplicator
    {
       
        public IEnumerable<string> RemoveDuplicates(List<string> initialList)
        {
            var noDuplicates = initialList.Distinct();
            return noDuplicates;

        }

        

        

        
    }
}
