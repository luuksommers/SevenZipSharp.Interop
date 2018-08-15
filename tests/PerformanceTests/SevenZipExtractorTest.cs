using System;
using System.IO;
using System.Reflection;
using SevenZip;

namespace PerformanceTests
{
    public class SevenZipExtractorTest
    {
        private string _version;

        public SevenZipExtractorTest(string version)
        {
            _version = version;

        }

        public void Setup()
        {
            var path = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                _version,
                Environment.Is64BitProcess ? "x64" : "x86", "7z.dll");
            SevenZip.SevenZipBase.SetLibraryPath(path);
        }

        public void Extract()
        {
            using (Stream extractFrom = File.OpenRead("test.7z"))
            {
                using (SevenZipExtractor extractor = new SevenZipExtractor(extractFrom))
                {
                    extractor.ExtractFile("readme.md", new MemoryStream());
                }
            }
        }
    }
}
