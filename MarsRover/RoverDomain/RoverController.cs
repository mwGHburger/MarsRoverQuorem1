using System.Collections.Generic;

namespace MarsRover
{
    public class RoverController
    {
        private List<IRoverCommand> _roverCommands;

        public RoverController(List<IRoverCommand> roverCommands)
        {
            _roverCommands = roverCommands;
        }

        public void ExecuteInputCommands(List<char> userInputCommands)
        {
            foreach(char userInputCommand in userInputCommands)
            {
                var roverCommand = _roverCommands.Find(x  => x.KeyCommand.Equals(userInputCommand));
                roverCommand.Execute();
            }
        }
    }
}