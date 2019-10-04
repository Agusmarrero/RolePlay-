using RoleplayGame.Items;
using RoleplayGame.Scenarios;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IScenario scenario = new ConsoleScenario();
            scenario.Setup();
            scenario.Run();
        }
    }
}
