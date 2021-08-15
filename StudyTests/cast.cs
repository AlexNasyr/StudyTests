using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTests {
    public class CastTesting {
        public static int ExplicitCast(double d) {
            return (int)d;
        }
        public static int ConvertCast(double d) {
            return Convert.ToInt32(d); 
        }
    }
}
