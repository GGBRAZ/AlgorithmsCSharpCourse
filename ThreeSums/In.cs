namespace ThreeSums
{
    public static class In
    {
        public static IEnumerable<int> ReadInts(string filepath)
        {
            using (TextReader reader = File.OpenText(filepath))
            {
                string lastLine;
                while ((lastLine = reader.ReadLine()) != null)
                {
                    yield return int.Parse(lastLine);
                }

            }
        }
    }
}
