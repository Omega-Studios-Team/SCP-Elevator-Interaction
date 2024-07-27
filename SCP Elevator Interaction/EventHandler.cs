using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using PlayerRoles;
using PlayerRoles.PlayableScps.Scp096;
using Exiled.Events.EventArgs.Player;
using System.Collections.Generic;

namespace SCPElevatorInteraction
{
    public class EventHandler
    {
        private readonly Config _config;

        public EventHandler(Config config) => _config = config;

        public void OnInteractingElevator(InteractingElevatorEventArgs ev)
        {
            bool isBlacklisted = false;

            switch (ev.Lift.Type)
            {
                case ElevatorType.GateA:
                    isBlacklisted = _config.ScpBlacklistGateA.Contains(ev.Player.Role);
                    break;
                case ElevatorType.GateB:
                    isBlacklisted = _config.ScpBlacklistGateB.Contains(ev.Player.Role);
                    break;
                case ElevatorType.LczA:
                    isBlacklisted = _config.ScpBlacklistElevatorSystemA.Contains(ev.Player.Role);
                    break;
                case ElevatorType.LczB:
                    isBlacklisted = _config.ScpBlacklistElevatorSystemB.Contains(ev.Player.Role);
                    break;
                case ElevatorType.Scp049:
                    isBlacklisted = _config.ScpBlacklistScp049.Contains(ev.Player.Role);
                    break;
                case ElevatorType.Nuke:
                    isBlacklisted = _config.ScpBlacklistAlphaWarhead.Contains(ev.Player.Role);
                    break;
                default:
                    break;
            }

            if (isBlacklisted && !ev.Player.HasScp096Target())
            {
                ev.IsAllowed = false; 
                string message = _config.HintMessage;

                if (_config.UseHint)
                {
                    ev.Player.ShowHint(message, _config.HintDuration * 1000); 
                }
                else
                {
                    ev.Player.Broadcast(_config.HintDuration, message);
                }
            }
        }
    }

    public static class PlayerExtensions
    {
        public static bool HasScp096Target(this Player player)
        {
            if (player.Role == RoleTypeId.Scp096)
            {
                var scp096Role = player.ReferenceHub.roleManager.CurrentRole as Scp096Role;
                if (scp096Role != null && scp096Role.SubroutineModule.TryGetSubroutine<Scp096TargetsTracker>(out var targetsTracker))
                {
                    return targetsTracker.Targets.Count > 0;
                }
            }
            return false;
        }
    }
}















