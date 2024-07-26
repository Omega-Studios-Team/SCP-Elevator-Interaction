﻿using System.Collections.Generic;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace SCPElevatorInteraction
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public List<RoleTypeId> ScpAllowedGateA { get; set; } = new List<RoleTypeId> { RoleTypeId.Scp049, RoleTypeId.Scp096 };
        public List<RoleTypeId> ScpAllowedGateB { get; set; } = new List<RoleTypeId> { RoleTypeId.Scp173, RoleTypeId.Scp106 };
        public string HintMessage { get; set; } = "You are not allowed to use this elevator.";
        public string HintMessage096Rage { get; set; } = "SCP-096 can use this elevator during rage.";
    }
}