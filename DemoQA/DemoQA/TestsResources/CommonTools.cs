using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.TestsResources
{
    static class CommonTools
    {
        public static string CreateRandomString(int lenght)
        {
            Random rnd = new Random(DateTime.UtcNow.Millisecond);

        }
    }
}
