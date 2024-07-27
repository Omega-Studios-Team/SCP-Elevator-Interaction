using Exiled.API.Interfaces;
using PlayerRoles;
using System.Collections.Generic;
using System.ComponentModel;

namespace SCPElevatorInteraction
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("List of SCPs that are blacklisted from using Gate A elevators.")]
        public List<RoleTypeId> ScpBlacklistGateA { get; set; } = new List<RoleTypeId>();

        [Description("List of SCPs that are blacklisted from using Gate B elevators.")]
        public List<RoleTypeId> ScpBlacklistGateB { get; set; } = new List<RoleTypeId>();

        [Description("List of SCPs that are blacklisted from using Elevator System A.")]
        public List<RoleTypeId> ScpBlacklistElevatorSystemA { get; set; } = new List<RoleTypeId>();

        [Description("List of SCPs that are blacklisted from using Elevator System B.")]
        public List<RoleTypeId> ScpBlacklistElevatorSystemB { get; set; } = new List<RoleTypeId>();

        [Description("List of SCPs that are blacklisted from using SCP-049's elevator.")]
        public List<RoleTypeId> ScpBlacklistScp049 { get; set; } = new List<RoleTypeId>();

        [Description("List of SCPs that are blacklisted from using the Alpha Warhead elevator.")]
        public List<RoleTypeId> ScpBlacklistAlphaWarhead { get; set; } = new List<RoleTypeId>();

        [Description("The duration of the hint message displayed to players.")]
        public ushort HintDuration { get; set; } = 5;

        [Description("The message displayed to players when they are not allowed to use an elevator.")]
        public string HintMessage { get; set; } = "You are not allowed to use this elevator.";

        [Description("Whether to use hint messages (true) or broadcast messages (false).")]
        public bool UseHint { get; set; } = true;
    }
}
