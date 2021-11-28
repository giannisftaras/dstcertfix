using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DSTCertFix
{
    internal class browser_detect
    {
        private readonly Dictionary<string, string> browsers = new Dictionary<string, string> {
            { "firefox", "Mozilla Firefox" },
            { "chrome", "Google Chrome" },
            { "iexplore", "Internet Explorer" },
            { "MicrosoftEdgeCP", "Microsoft Edge" },
            { "msedge", "Microsoft Edge" },
            { "brave", "Brave Browser" }
        };

        public bool BrowserIsOpen()
        {
            return Process.GetProcesses().Any(this.IsBrowserWithWindow);
        }

        private bool IsBrowserWithWindow(Process process)
        {
            return this.browsers.TryGetValue(process.ProcessName, out var browserTitle) && process.MainWindowTitle.Contains(browserTitle);
        }
    }
}
