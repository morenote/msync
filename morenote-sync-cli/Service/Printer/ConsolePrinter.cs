using morenote_sync_cli.Interface;
using morenote_sync_cli.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morenote_sync_cli.Service.Printer
{
    public class ConsolePrinter : IPrinter
    {
        public void WirteLine(string msg)
        {
            ConsoleUtil.WriteLine(msg);
        }

        public void WriteError(string msg)
        {
            ConsoleUtil.WriteLine(msg, ConsoleColor.Red);
        }

        public void WriteSuccess(string msg)
        {
            ConsoleUtil.WriteLine(msg, ConsoleColor.Green);
        }

        public void WriteWarning(string msg)
        {
            ConsoleUtil.WriteLine(msg, ConsoleColor.Yellow);
        }
    }
}