namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            List<string> _value = new List<string>() { "abaccadcc", "xyzxy" };
            List<string> _expected = new List<string>() { "ccccaaabd", "xxyyz" };
            List<string> result = new List<string>();    

            foreach (var word in _value)
            {
                result.Add(ConsoleApp1.SortingOperationsHelper.SortingOperations(word));              
            }

            Assert.That(result, Is.EqualTo(_expected));
        }

        [Test]
        public void Test2()
        {
            List<string> _value = new List<string>() { "dulgvgzwqg", 
                "gxtjtmtywr", 
                "hnlnxiupgt", 
                "gzjotckivp", 
                "dpwwsdptae", 
                "pcscpilknb", 
                "btvyhhmflf", 
                "artrtnqxcr", 
                "nrtcmcoadn", 
                "fkdsgnekft" };
            List<string> _expected = new List<string>() { "gggdlquvwz", 
                "tttgjmrwxy", 
                "nnghilptux",
                "cgijkoptvz", 
                "ddppwwaest", 
                "ccppbiklns", 
                "ffhhblmtvy", 
                "rrrttacnqx", 
                "ccnnadmort", 
                "ffkkdegnst" };
            List<string> result = new List<string>();

            foreach (var word in _value)
            {
                result.Add(ConsoleApp1.SortingOperationsHelper.SortingOperations(word));
            }

            Assert.That(result, Is.EqualTo(_expected));
        }

        [Test]
        public void Test3()
        {
            List<string> _value = new List<string>() { "wzenwebuau", 
                "vokfxzynwl", 
                "neldfeyrxk", 
                "wqadfiodgs", 
                "ykiuvzfcbc" };
            List<string> _expected = new List<string>() { "eeuuwwabnz", 
                "fklnovwxyz", 
                "eedfklnrxy", 
                "ddafgioqsw", 
                "ccbfikuvyz" };
            List<string> result = new List<string>();

            foreach (var word in _value)
            {
                result.Add(ConsoleApp1.SortingOperationsHelper.SortingOperations(word));
            }

            Assert.That(result, Is.EqualTo(_expected));
        }
    }
}