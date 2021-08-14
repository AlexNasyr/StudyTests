using System.Collections.Generic;

namespace StudyTests {
    public class foreachTesting {
        public static List<int> TraditionalForeach(List<int> list) {
            List<int> evens = new List<int>();
            foreach (int i in list) {
                if (i % 2 == 0) {
                    evens.Add(i);
                }
            }
            return evens;
        }
        public static IEnumerable<int> YieldForeach(List<int> list) {
            foreach (int i in list) {
                if (i % 2 == 0) {
                    yield return i;
                }
            }
        }
    }
}
