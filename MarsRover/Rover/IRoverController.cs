using System.Collections.Generic;

namespace MarsRover
{
    public interface IRoverController
    {
        void ExecuteInputCommands(List<char> userInputCommands);
    }
}