namespace StreamWriter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] lines = { "First 250", "Second 888", "Third One" };
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Projects\Read3.txt"))
            {
                foreach (var line in lines)
                {
                    if (line.Contains(("Third")))
                    {
                        file.WriteLine((line));
                    }
                }
            }
            
            // add text
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Projects\Read3.txt", true))
            {
                file.WriteLine("Additional Contain");
            }
        }
    }
}