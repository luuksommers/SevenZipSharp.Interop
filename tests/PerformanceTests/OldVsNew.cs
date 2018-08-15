using BenchmarkDotNet.Attributes;

namespace PerformanceTests
{
    [ClrJob]
    [RPlotExporter, RankColumn]
    public class OldVsNew
    {
        private SevenZip9_38 sevenZip9_38 = new SevenZip9_38();
        private SevenZip18_05 sevenZip18_05 = new SevenZip18_05();

        [GlobalSetup(Target = nameof(SevenZip9_38Extract))]
        public void GlobalSetupA() => sevenZip9_38.Setup();

        [GlobalSetup(Target = nameof(SevenZip18_05Extract))]
        public void GlobalSetupB() => sevenZip18_05.Setup();

        [Benchmark]
        public void SevenZip9_38Extract() => sevenZip9_38.Extract();

        [Benchmark]
        public void SevenZip18_05Extract() => sevenZip18_05.Extract();
    }
}
