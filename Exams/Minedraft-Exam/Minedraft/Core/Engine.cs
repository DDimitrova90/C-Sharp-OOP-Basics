namespace Minedraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private bool isRunning;
        private DraftManager draftManager;

        public Engine()
        {
            this.isRunning = true;
            this.draftManager = new DraftManager();
        }

        public void Run()
        {
            while (this.isRunning)
            {
                string inputCommand = this.ReadInput();

                List<string> commandParameters = this.ParseInput(inputCommand);
                this.DistributeCommand(commandParameters);
            }
        }

        private void DistributeCommand(List<string> commandParameters)
        {
            string command = commandParameters[0];
            commandParameters.Remove(command);

            switch (command)
            {
                case "RegisterHarvester":
                    string harvester = this.draftManager.RegisterHarvester(commandParameters);
                    this.OutputWriter(harvester);
                    break;
                case "RegisterProvider":
                    string provider = this.draftManager.RegisterProvider(commandParameters);
                    this.OutputWriter(provider);
                    break;
                case "Day":
                    string dayResult = this.draftManager.Day();
                    this.OutputWriter(dayResult);
                    break;
                case "Mode":
                    string result = this.draftManager.Mode(commandParameters);
                    this.OutputWriter(result);
                    break;
                case "Check":
                    result = this.draftManager.Check(commandParameters);
                    this.OutputWriter(result);
                    break;
                case "Shutdown":
                    isRunning = false;
                    result = this.draftManager.ShutDown();
                    this.OutputWriter(result);
                    break;
            }
        }

        private void OutputWriter(string harvester)
        {
            Console.WriteLine(harvester);
        }

        private List<string> ParseInput(string inputCommand)
        {
            return inputCommand
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();
        }

        private string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}
