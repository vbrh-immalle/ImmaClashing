using System;
using System.IO;

namespace ImmaClashing
{
    public class ClashExample
    {
        TextReader r;
        TextWriter w;

        public ClashExample(string inputFile)
        {
            this.r = new StreamReader(inputFile.ToString());
            this.w = new StringWriter();
            Do();
        }

        private void Do()
        {
            string s = r.ReadLine();
            w.WriteLine(s.Length);
        }

        public string GetOutput()
        {
            w.Flush();
            return w.ToString();
        }
    }
}
