using CommandDpApp.Models;

namespace CommandDpApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICommand onCommand = new OnCommand(new Television());
            RemoteControl remote = new RemoteControl();
            remote.SetCommand(onCommand);
            remote.PressButton();

            ICommand offCommand = new OffCommand(new Television());
            remote.SetCommand(offCommand);
            remote.PressButton();
        }
    }
}
