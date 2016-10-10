using System;
using System.IO;
using System.Linq;

namespace Runner
{
    public class Communicator
    {
        public static readonly string SaveFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DIPS Coding Competition");

        private static readonly string communicationFile;

        static Communicator()
        {
            if (!Directory.Exists(SaveFolder))
            {
                Directory.CreateDirectory(SaveFolder);
            }

            communicationFile = Path.Combine(SaveFolder, "results.txt");
        }

        public void Reset()
        {
            var init = string.Join(",", new int[TestBase.NumberOfTests]);
            Write(init);
        }

        public void Write(string content)
        {
            using (var fileStream = new FileStream(communicationFile, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (var streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine(content);
                }
            }
        }

        public int[] Read()
        {
            try
            {
                string content = null;
                using (var fileStream = new FileStream(communicationFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (var streamReader = new StreamReader(fileStream))
                    {
                        content = streamReader.ReadLine();
                    }
                }

                if (content != null)
                {
                    return content.Split(',').Select(int.Parse).ToArray();
                }
            }
            catch (Exception e)
            {
                // TODO: Log e
            }

            return new int[TestBase.NumberOfTests];
        }
    }
}