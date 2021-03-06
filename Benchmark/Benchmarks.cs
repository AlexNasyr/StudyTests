using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using StudyTests;

namespace Benchmarks {

    [MemoryDiagnoser]
    [RankColumn]
    public class BenchMark001 {
        public List<int> list;
        public BenchMark001() {
            list = new();
            for (int i = 0; i < 1000; i++) {
                list.Add(i);
            }
        }

        [Benchmark]
        public void TryTraditionalForeach() {
            var result = foreachTesting.TraditionalForeach(list);
        }
        [Benchmark]
        public void TryYieldForeach() {
            var result = foreachTesting.YieldForeach(list);
        }
    }

    [MemoryDiagnoser]
    [RankColumn]
    public class BenchMark002 {
        [Benchmark]
        public void ExplicitBenckmark() {
            var result = CastTesting.ExplicitCast(10.2);
        }
        [Benchmark]
        public void ConvertBenckmark() {
            var result = CastTesting.ConvertCast(10.2);
        }
    }
}
