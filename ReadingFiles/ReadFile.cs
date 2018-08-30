using System;
using System.IO;
using System.Linq;

namespace ReadingFiles
{
    public class ReadFile
    {
        public static void CountWords()
        {
            var path = @"c:\users\shahe\source\repos\ReadingFiles\ReadingFiles\HPExcerpt.txt";
            
            if (File.Exists(path))
            {
                //Console.WriteLine("File Exists!");
                var content = File.ReadAllText(path);
                var punctuation = content.Where(Char.IsPunctuation).Distinct().ToArray();
                var words = content.Split().Select(x => x.Trim(punctuation));
                Console.WriteLine("The number of words in the text file is {0}.", words.Count());
            }
        }//end method

        public static void LongestWord()
        {
            var path = @"c:\users\shahe\source\repos\ReadingFiles\ReadingFiles\HPExcerpt.txt";

            if (File.Exists(path))
            {
                //Console.WriteLine("File Exists!");
                var content = File.ReadAllText(path);
                var punctuation = content.Where(Char.IsPunctuation).Distinct().ToArray();
                var words = content.Split().Select(x => x.Trim(punctuation));

                //find logest word in text
                var longest = words.First();
                var current = words.GetEnumerator();
                current.MoveNext();
                var word = current.Current;
                for (int i = 0; i < words.Count(); i++)
                {
                    if (longest.Length < word.Length)
                    {
                        longest = word;
                    }

                    current.MoveNext();
                    word = current.Current;
                }//end for

                Console.WriteLine("The longest word is {0}.", longest);
            }
        }//end method
    }
}
