using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dnn.PersonaBar.Prompt.Models;
using DotNetNuke.Entities.Portals;
using Dnn.PersonaBar.Prompt.Common;
using Dnn.PersonaBar.Prompt.Interfaces;
using DotNetNuke.Entities.Users;
using Dnn.PersonaBar.Prompt.Attributes;

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