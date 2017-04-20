using Dnn.PersonaBar.Prompt.Attributes;
using Dnn.PersonaBar.Prompt.Common;
using Dnn.PersonaBar.Prompt.Interfaces;
using Dnn.PersonaBar.Prompt.Models;
using DotNetNuke.Entities.Portals;
using DotNetNuke.Entities.Users;

namespace KellyFord.Prompt.Commands
{
    [ConsoleCommand("get-time", "kf", "Returns the Server Time", new string[] { "format" })]
    public class GetTime : ConsoleCommandBase, IConsoleCommand
    {
        private const string FLAG_FORMAT = "format";
        public string Format { get; private set; }

        public string ValidationMessage { get; }

        public void Init(string[] args, PortalSettings portalSettings, UserInfo userInfo, int activeTabId)
        {
            base.Initialize(args, portalSettings, userInfo, activeTabId);

            // Format Flag:
            // ------------------

            // If Flag exists, read it
            // use base class' HasFlag function to determine if flag was passed
            if (HasFlag(FLAG_FORMAT))
            {
                // use base class' Flag() function to retrieve the value.
                // we're passing in "F" to use if the Flag doesn't have a value
                // "F" will do a full format on the date and time.
                Format = Flag(FLAG_FORMAT, "F");
            }
            else
            {
                // no Format flag found - use a default of 'F' for full date formatting
                Format = "F";
            }
        }

        public bool IsValid()
        {
            return string.IsNullOrEmpty(ValidationMessage);
        }

        public ConsoleResultModel Run()
        {
            return new ConsoleResultModel(System.DateTime.Now.ToString(Format)) { };
        }
    }
}