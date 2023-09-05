using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionGame.Library.Commands.ICommands
{
    public interface IBaseCommand
    {
        abstract void ExecuteCommand();
        virtual bool CanExecuteCommand() => true;

    }
}
