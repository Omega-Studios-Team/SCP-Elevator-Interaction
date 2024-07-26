using System.Collections.Generic;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace SCPElevatorInteraction
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        public List<RoleTypeId> ScpBlacklistGateA { get; set; } = new List<RoleTypeId> { RoleTypeId.Scp049, RoleTypeId.Scp096 };
        public List<RoleTypeId> ScpBlacklistGateB { get; set; } = new List<RoleTypeId> { RoleTypeId.Scp173, RoleTypeId.Scp106 };
        public List<RoleTypeId> ScpBlacklistElevatorSystemA { get; set; } = new List<RoleTypeId> { RoleTypeId.Scp939 };
        public List<RoleTypeId> ScpBlacklistElevatorSystemB { get; set; } = new List<RoleTypeId> { RoleTypeId.Scp079 };
        public List<RoleTypeId> ScpBlacklistScp049 { get; set; } = new List<RoleTypeId> { RoleTypeId.Scp049 };
        public List<RoleTypeId> ScpBlacklistAlphaWarhead { get; set; } = new List<RoleTypeId> { RoleTypeId.Scp106 };

        public string HintMessage { get; set; } = "You are not allowed to use this elevator.";
    }
}
