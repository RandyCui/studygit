using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Home
    {
        public bool Test(string testStr)
        {
            if (string.IsNullOrEmpty(testStr))
            {
                return false;
            }
            if (testStr.Length > 5)
            {
                return false;
            }
            return true;
        }
    }
}
