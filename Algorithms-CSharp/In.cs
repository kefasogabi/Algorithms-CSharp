using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_CSharp
{
    internal class In
    {
        public static IEnumerable<int> ReadInts(string filePath)
        {
            using(TextReader reader = File.OpenText(filePath))
            {
                string lastLine;
                while((lastLine = reader.ReadLine()) != null)
                {
                    yield return int.Parse(lastLine);
                }
            }
        }
    }
}
