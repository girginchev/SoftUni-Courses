namespace WriteToFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class WriteToFile
    {
        public static void Main()
        {
            var text = File.ReadAllText("sample_text.txt").Split(new char[] { '.', ',', '!', '?', ':' },StringSplitOptions.RemoveEmptyEntries);
            var result = string.Join("", text);
            File.WriteAllText("result.txt", result);
        }
    }
}
