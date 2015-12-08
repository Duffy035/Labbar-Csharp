namespace Lab5
{
    static class IO
    {
        public static string Input(string output, string[] outputs = null)
        {
            string input = "";

            if (output != null)
            {
                Output(output);
                input = System.Console.ReadLine();
            }
            if (outputs != null)
            {
                Output(null, outputs);
                input = System.Console.ReadLine();
            }

            return input;
        }
        public static void Output(string output, string[] outputs = null)
        {
            if (output != null)
            {
                System.Console.WriteLine(output);
            }
            if (outputs != null)
            {
                for (int i = 0; i < outputs.Length; i++)
                {
                    if (outputs[i] != null)
                    {
                        System.Console.WriteLine(outputs[i]);
                    }
                }
            }
        }
        public static void StartOver(string output = "")
        {
            Output(output);
            System.Threading.Thread.Sleep(3000);
            System.Console.Clear();
        }
    }
}
