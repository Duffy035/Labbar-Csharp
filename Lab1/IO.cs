namespace Lab1
{
    static class IO
    {
        public static string Input(string output)
        {
            string input = "";

            if (output != null)
            {
                Output(output);
                input = System.Console.ReadLine();
            }

            return input;
        }
        public static string Input(string[] outputs)
        {
            string input = "";

            if (outputs != null)
            {
                Output(outputs);
                input = System.Console.ReadLine();
            }

            return input;
        }
        public static void Output(string output)
        {
            if (output != null)
            {
                System.Console.WriteLine(output);
            }
        }
        public static void Output(string[] outputs)
        {
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
            System.Threading.Thread.Sleep(5000);
            System.Console.Clear();
        }
    }
}
