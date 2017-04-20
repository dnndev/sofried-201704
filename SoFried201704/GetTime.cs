using Dnn.PersonaBar.Prompt.Attributes;
using Dnn.PersonaBar.Prompt.Common;
using Dnn.PersonaBar.Prompt.Interfaces;
using Dnn.PersonaBar.Prompt.Models;
using DotNetNuke.Entities.Portals;
using DotNetNuke.Entities.Users;

namespace KellyFord.Prompt.Commands
{
    [ConsoleCommand("get-time", "kf", "Returns the Server Time", new string[] { })]
    public class GetTime : ConsoleCommandBase, IConsoleCommand
    {
        public string ValidationMessage { get; }

        public void Init(string[] args, PortalSettings portalSettings, UserInfo userInfo, int activeTabId)
        {
            base.Initialize(args, portalSettings, userInfo, activeTabId);
        }

        public bool IsValid()
        {
            return string.IsNullOrEmpty(ValidationMessage);
        }

        public ConsoleResultModel Run()
        {
            return new ConsoleResultModel("Success!");
        }
    }
}