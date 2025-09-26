using BenchmarkDotNet.Attributes;

namespace LeetCode.ConsoleApp.Challenges.Hashtables.LetterCombinationsOfPhoneNumber
{
    [MemoryDiagnoser]
    public class Challenge
    {
        public List<string> Inputs { get; set; }
        public Challenge()
        {
            Inputs = new List<string>();
            Inputs.Add("237");    // esperado: ["adg","adh","adi","aeg","aeh","aei","afg","afh","afi","bdg","bdh","bdi","beg","beh","bei","bfg","bfh","bfi","cdg","cdh","cdi","ceg","ceh","cei","cfg","cfh","cfi"]  
            Inputs.Add("23");          // esperado: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
            Inputs.Add("");         // esperado: []
            Inputs.Add("2");        // esperado: ["a","b","c"]
            Inputs.Add("5678"); // esperado: ["jmpt","jmpu","jmpv","jmqt","jmqu","jmqv","jmrt","jmru","jmrv","jnpt","jnpu","jnpv","jnqt","jnqu","jnqv","jnrt","jnru","jnrv","kopr","kops","kopt","koqr","koqs","koqt","korr","kors","kort","kprs","kprt","kqrs","kqrt","krst","lmpt","lmpu","lmpv","lmqt","lmqu","lmqv","lmrt","lmru","lmrv","lnpt","lnpu","lnpv","lnqt","lnqu","lnqv","lnrt","lnru","lnrv","lopr","lops","lopt","loqr","loqs","loqt","lorr","lors","lort","lprs","lprt","lqrs","lqrt","lrst"]
            Inputs.Add("9");       // esperado: ["w","x","y","z"]
            Inputs.Add("23456789"); 
            Inputs.Add("222");     // esperado: ["aaa","aab","aac","aba","abb","abc","aca","acb","acc","baa","bab","bac","bba","bbb","bbc","bca","bcb","bcc","caa","cab","cac","cba","cbb","cbc","cca","ccb","ccc"]
            Inputs.Add("7777"); // esperado: ["pppp","pppq","pppr","ppps","ppqp","ppqq","ppqr","ppqs","pprp","pprq","pprr","pprs","pspp","pspq","pspr","psps","psqp","psqq","psqr","psqs","psrp","psrq","psrr","psrs","qppp","qppq","qppr","qpps","qpqp","qpqq","qpqr","qpqs","qprp","qprq","qprr","qprs","qspp","qspq","qspr","qsps","qsqp","qsqq","qsqr","qsqs","qsrp","qsrq","qsrr","qsrs","rppp","rppq","rppr","rpps","rpqp","rpqq","rpqr","rpqs","rprp","rprq","rprr","rprs","rspp","rspq","rspr","rsps","rsqp","rsqq","rsqr","rsqs","rsrp","rsrq","rsrr","rsrs","sppp","sppq","sppr","spps","spqp","spqq","spqr","spqs","sprp","sprq","sprr","sprs","","sspp","","sspq","","sspr","","ssps","","ssqp","","ssqq","","ssqr","","ssqs","","ssrp","","ssrq","","ssrr","","ssrs"]
        }

        [Benchmark]
        public void RunMy()
        {
            foreach (var input in Inputs)
            {
                var solution = new MySolution(input);
                var result = solution.Run();
                //Console.WriteLine($"Input: {input} => Combinations: [{string.Join(", ", result)}]");
            }
        }

        [Benchmark]
        public void RunBest()
        {
            foreach (var input in Inputs)
            {
                var solution = new BestSolution(input);
                var result = solution.Run();
                //Console.WriteLine($"Input: {input} => Combinations: [{string.Join(", ", result)}]");
            }
        }
    }
}
