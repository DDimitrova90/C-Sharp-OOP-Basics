namespace BashSoft
{
    using System;

    public class InputReader
    {
        private const string endCommand = "quit";
        private CommandInterpreter interpreter;

        public InputReader(CommandInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }

        public void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}> ");
            string input = Console.ReadLine();
            input = input.Trim();

            while (input != endCommand)
            {
                OutputWriter.WriteMessage($"{SessionData.currentPath}> ");
                this.interpreter.InterpredCommand(input);

                input = Console.ReadLine();
                input = input.Trim();
            }
        }
    }
}
