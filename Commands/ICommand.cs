using System;

namespace Warden.Messages.Commands
{
    //Marker interface
    public interface ICommand
    {
        Request Request { get; set; }
    }
}